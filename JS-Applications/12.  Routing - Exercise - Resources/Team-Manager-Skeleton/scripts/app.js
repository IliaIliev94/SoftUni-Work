 // TODO
 const auth = firebase.auth();
 const baseURL = `https://team-manager-50fc6.firebaseio.com`;
 const app = Sammy('#main', function() {

    this.use('Handlebars', 'hbs');

     this.get('#/home', function(context) {
        isLoggedIn(context);
         loadPartials(context)
         .then(function() {
            this.partial('../templates/home/home.hbs');
         });
     });

     this.get('#/login', function(context) {
         loadPartials(context)
         .then(function() {
            this.partial('../templates/login/loginPage.hbs')
         });
     });

     this.get('#/register', function(context) {
         loadPartials(context)
         .then(function() {
            this.partial('../templates/register/registerPage.hbs');
         });
     });

     this.get('#/about', function(context) {
        isLoggedIn(context);
        console.log(context)
         loadPartials(context)
         .then(function() {
            this.partial('../templates/about/about.hbs')
         });
     });

     this.post('#/register', function(context) {
         const {username, password, repeatPassword} = context.params;
         if(password !== repeatPassword) {
             alert('Password and requested password fields must be equal the same!');
             return;
         }
         auth.createUserWithEmailAndPassword(username, password)
            .then((user) => {
                // Signed in 
                // ...
            })
            .catch((error) => {
                var errorCode = error.code;
                var errorMessage = error.message;
                // ..
            });
     })

     this.post('#/login', function(context) {
        const {username, password} = context.params;
        firebase.auth().signInWithEmailAndPassword(username, password)
            .then(({user : {uid, email}}) => {
                localStorage.setItem('userInfo', JSON.stringify({uid, email}));
                context.redirect('#/home');
            })
            .catch((error) => {
                alert(`${error.code} - ${error.message}`);
            });
                });

    this.get('#/logout', function(context) {
        auth.signOut()
        .then((response) => {
            localStorage.removeItem('userInfo');
            context.redirect('#/home')
        })
        .catch(err => alert(err))
    });

    this.get('#/create', function(context) {
        isLoggedIn(context);
        loadPartials(context)
        .then(function() {
            this.partial('../templates/create/createPage.hbs');
        });
    });

    this.post('#/create', function(context) {
        const {name, comment} = context.params;
        fetch(`${baseURL}/teams.json`, {
            method: 'POST',
            body: JSON.stringify({
                "name": name,
                "comment": comment
            })
        })
        .then(() => context.redirect('#/home'))
        .catch((err) => console.log(err))
    });

    this.get('#/catalog', function(context) {
        isLoggedIn(context);

            let myres;

            this.loadPartials({
                'header': '../templates/common/header.hbs',
                'footer': '../templates/common/footer.hbs',
                'team': '../templates/catalog/team.hbs'
            })
            .then(function() {
                fetch(`${baseURL}/teams.json`)
                .then(res => res.json())
                .then(data => {
                    console.log(data);
                    context.teams = data;
                    this.partial('../templates/catalog/teamCatalog.hbs');
                })
                
            })
            
    });


    this.get('#/', function(context) {
        context.redirect('#/home');
    });
 });

(() => {
    app.run('#/home');
})();

function loadPartials(context) {
    return context.loadPartials({
        'header': '../templates/common/header.hbs',
        'footer': '../templates/common/footer.hbs',
        'registerForm': '../templates/register/registerForm.hbs',
        'loginForm': '../templates/login/loginForm.hbs',
        'createForm': '../templates/create/createForm.hbs',
    });
}

function getTemplate(path) {
    return fetch(path).then(res => res.text());
}

function isLoggedIn(context) {
    const userInfo = JSON.parse(localStorage.getItem('userInfo'));
    if(userInfo) {
        const {uid, email} = userInfo;
        context.loggedIn = true;
        context.username = email;
    }
}

