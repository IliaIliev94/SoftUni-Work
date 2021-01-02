const DB = firebase.firestore();
const userModel = firebase.auth();
const router = Sammy('#root', function() {

        this.use('Handlebars', 'hbs');

        this.get('/home', function(context) {
            DB.collection('offers')
            .get()
            .then(response => {
                console.log(response.docs[0].data());
                context.offers = response.docs.map((offer) => {return {id: offer.id, ...offer.data()}})
                extendContext(context)
                .then(function() {
                    this.partial('./templates/home.hbs');
                });
            })
        });

        this.get('/register', function(context) {
            extendContext(context)
            .then(function() {
                this.partial('./templates/register.hbs');
            })
            
        });

        this.post('/register', function(context) {
            const {email, password, rePassword} = context.params;

            if(password !== rePassword) {
                return;
            }
            userModel.createUserWithEmailAndPassword(email, password)
            .then((user) => {
              this.redirect('#/login');
            })
            .catch(error => console.log(error));
        });

        this.get('/login', function(context) {
            extendContext(context)
            .then(function() {
                this.partial('./templates/login.hbs');
            })
            
        });

        this.post('/login', function(context) {
            const {email, password} = context.params;
            userModel.signInWithEmailAndPassword(email, password)
            .then((user) => {
              saveUserData(user);
              this.redirect('#/home');
            })
            .catch(error => console.log(error))
        })

        this.get('/logout', function(context) {
            userModel.signOut()
                .then(response => {
                    clearUserData();
                    this.redirect('#/home');
                })
                .catch(err => console.log(err))
        });

        //Offer routes
        this.get('/create-offer', function(context) {
            extendContext(context)
            .then(function() {
                this.partial('./templates/createOffer.hbs');
            })
            
        });

        this.post('/create-offer', function(context) {
            const {productName, price, imageUrl, description, brand} = context.params;
            DB.collection('offers').add({
                productName,
                price,
                imageUrl,
                description,
                brand,
                salesman: getUserData().uid,
                clients: []
            })
            .then(productData => {
                this.redirect('#/home');
            })
        });

/*         this.get('/edit-offer', function(context) {
            extendContext(context)
            .then(function() {
                this.partial('./templates/editOffer.hbs');
            })
            
        }); */

        this.get('/details/:offerId', function(context) {
            const {offerId} = context.params;
            
            DB.collection('offers').doc(offerId).get()
            .then(response => {
                const actualOfferData = response.data();
                const imInTheClientsList = actualOfferData.clients.includes(getUserData().uid);
                console.log(imInTheClientsList);
                const imTheSalesman = actualOfferData.salesman === getUserData().uid;
                context.offer = {...response.data(), imTheSalesman, offerId, imInTheClientsList};
                extendContext(context)
                .then(function() {
                    this.partial('./templates/details.hbs');
                })
            })
        });

        this.get('/edit/:offerId', function(context) {
            console.log(context);
            const {offerId} = context.params;
            DB.collection('offers').doc(offerId).get()
            .then(response => {
                context.offer = {...response.data(), offerId};
                extendContext(context)
                .then(function() {
                    this.partial('./templates/editOffer.hbs');
                })
            });
        });

        this.post('/edit/:offerId', function(context) {
            const{productName, price, imageUrl, description, brand, clients, offerId} = context.params;
            DB.collection('offers')
            .doc(offerId)
            .get()
            .then((response) => {
                return DB.collection('offers').doc(offerId)
                .set({
                    ...response.data(),
                    productName,
                    price,
                    imageUrl,
                    description,
                    brand,
                    salesman: getUserData().uid
                })
                .then((reponse) => {
                    this.redirect(`#/details/${offerId}`);
                })
            })
           
            .catch(error => console.log(error));
        });

        this.get('#/delete/:offerId', function(context) {
            const {offerId} = context.params;
            DB.collection('offers').doc(offerId)
            .delete()
            .then(res => {
                console.log('yes');
                console.log(res);
                this.redirect('#/home');
            })
            .catch(error => console.log(error));
        });

        this.get('#/buy/:offerId', function(context) {
            const {offerId} = context.params;
            let currentUserId = getUserData().uid;
            DB.collection('offers').doc(offerId)
            .get()
            .then(response => {
                const offerData = response.data();
                console.log(offerData);
                offerData.clients.push(currentUserId)
                return DB.collection('offers').doc(offerId)
                .set(offerData)
                .then(response => {
                    this.redirect(`#/details/${offerId}`);
                })
            })
            .catch(err => console.log(err));
        });
});

(() => {
    router.run('#/home');
})();

function extendContext(context) {
    const user = getUserData();
    context.isLoggedIn = Boolean(user);
    context.email = user ? user.email : '';

    return context.loadPartials({
        'header': './partials/header.hbs',
        'footer': './partials/footer.hbs'
    });
};

function saveUserData(data) {
    const {user: {email, uid}} = data;
    localStorage.setItem('user', JSON.stringify({email, uid}))
};

function getUserData() {
    const user = localStorage.getItem('user');
    console.log(user);
    return user ? JSON.parse(user) : null;
};

function clearUserData() {
    localStorage.removeItem('user');
};