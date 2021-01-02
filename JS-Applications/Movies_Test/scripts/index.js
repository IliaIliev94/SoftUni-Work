const baseUrl = `https://movies-dc6e7.firebaseio.com/movies.json`
const router = Sammy('#container', function() {
    this.use('Handlebars', 'hbs');

    this.get('/home', function(context) {
        checkifUserIsLoggedIn(context);
        fetch(baseUrl)
        .then(res => res.json())
        .then((data) => {
            let test = Object.keys(data).map(movie => {return {id: movie, ...data[movie]}});
            context.movies = test;
            loadPartials(context)
            .then(function() {
                this.partial('../templates/home.hbs');
            })
        })
    });

    this.get('/register', function(context) {
        loadPartials(context)
        .then(function() {
            this.partial('../templates/register.hbs');
        })
    });

    this.post('/register', function(context) {
        const {email, password, repeatPassword} = context.params;
        if(password !== repeatPassword) {
            return;
        }
        firebase.auth().createUserWithEmailAndPassword(email, password)
            .then((user) => {
                saveUserData(user);
                setTimeout(() => {
                    this.redirect('/home');
                }, 1000);
            })
            .catch((error) => {
                var errorCode = error.code;
                var errorMessage = error.message;
                // ..
            });
    });

    this.get('/login', function(context) {
        loadPartials(context)
        .then(function() {
            this.partial('../templates/login.hbs');
        });
        
    });

    this.post('/login', function(context) {
        console.log('yes');
        const {email, password} = context.params;
        firebase.auth().signInWithEmailAndPassword(email, password)
            .then((user) => {
                saveUserData(user);
                this.redirect('#/home');
            })
            .catch((error) => {
                var errorCode = error.code;
                var errorMessage = error.message;
                console.log(errorCode);
                console.log(errorMessage);
            });
    });

    this.get('/logout', function(context) {
        firebase.auth().signOut().then(() =>  {
            clearUserData();
            this.redirect('#/home');
          }).catch(function(error) {
            console.log(error);
          });
    });

    this.get('/add-movie', function(context) {
        loadPartials(context)
        .then(function() {
            this.partial('../templates/addMovie.hbs');
        });
    });

    this.post('/add-movie', function(context) {
        const {title, description, imageUrl} = context.params;
        const creater = getUserData().uid;
        fetch(baseUrl, {
            method: 'POST',
            body: JSON.stringify({
                title,
                description,
                imageUrl,
                creater,
                peopleLiked: [true]
            })
        })
        .then(res => res.json())
        .then(data => {
            this.redirect('#/home');
        });
    });

    this.get('/details/:id', function(context) {
        checkifUserIsLoggedIn(context);
        const {id} = context.params;
        fetch(`https://movies-dc6e7.firebaseio.com/movies/${id}.json`)
        .then(res => res.json())
        .then(data => {
            const {creater} = data;
            const {peopleLiked} = data;
            context.isLiked = peopleLiked.includes(getUserData().uid);
            context.likes = peopleLiked.length - 1;
            context.isCreater = getUserData().uid === creater;
            context.movie = {id, title: data.title, description: data.description, imageUrl: data.imageUrl};
            loadPartials(context)
            .then(function() {
                this.partial('../templates/details.hbs');
            });
        });
    });

    this.get('/edit/:id', function(context) {
        const {id} = context.params;
        context.id = id;
        checkifUserIsLoggedIn(context);
        loadPartials(context)
        .then(function() {
            this.partial('../templates/editMovie.hbs');
        });
    });

    this.post('/edit/:id', function(context) {
        checkifUserIsLoggedIn(context);
        const {id, title, imageUrl, description} = context.params;
        fetch(`https://movies-dc6e7.firebaseio.com/movies/${id}.json`)
        .then(res => res.json())
        .then(data => {
            const {creater, peopleLiked} = data;
            fetch(`https://movies-dc6e7.firebaseio.com/movies/${id}.json`, {
                method: 'PUT',
                body: JSON.stringify({
                    title,
                    imageUrl,
                    description,
                    creater,
                    peopleLiked
                })
            })
            .then(result => result.json())
            .then(map => {
                this.redirect(`details/${id}`);
            });
        })
    })

    this.get('/like/:id', function(context) {
        const {id} = context.params;
        fetch(`https://movies-dc6e7.firebaseio.com/movies/${id}.json`)
        .then(res => res.json())
        .then(data => {
            const peopleLiked = data.peopleLiked;
            peopleLiked.push(getUserData().uid)
            const {creater, imageUrl, title, description} = data;
            fetch(`https://movies-dc6e7.firebaseio.com/movies/${id}.json`, {
                method: 'PUT',
                body: JSON.stringify({
                    creater,
                    imageUrl,
                    title,
                    description,
                    peopleLiked
                })
            })
            .then(function() {
                this.redirect(`/details/${id}`);
            })
        });
    });

    this.get('/delete/:id', function(context) {
        const {id} = context.params;
        fetch(`https://movies-dc6e7.firebaseio.com/movies/${id}.json`, {
            method: 'DELETE'
        })
        .then(res => res.json())
        .then(data => {
            this.redirect('/home');
        })
        .catch(err => console.log(err));
    })
});

(() => {
    router.run('#/home');
})()