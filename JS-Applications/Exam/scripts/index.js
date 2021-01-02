const router = Sammy('#container', function() {

    this.use('Handlebars', 'hbs');
    this.get('/', function(context) {
        this.redirect('/home');
    })

    this.get('/home', function(context) {
        getAll()
        .then(data => {
            context.destinations = data;
            extendContext(context)
            .then(function() {
                this.partial('../templates/home.hbs');
            })
        })
    })

    this.get('/register', function(context) {
        extendContext(context)
        .then(function() {
            this.partial('../templates/register.hbs');
        });
    });

    this.post('/register', function(context) {
        const {email, password, rePassword} = context.params;
        if(!validateEmail(email) || (password.length < 1 || rePassword.length < 1) || (password != rePassword)) {
            notify('errorBox', 'Invalid email/password.');
            clearFields('formRegister');
            return;
        }
        register(email, password)
        .then(userData => {
            const {user: {uid, email}} = userData;
            const data = JSON.stringify({uid, email});
            saveUserData(data);
            notify('infoBox', 'Registration successful.');
            setTimeout(() => {
                this.redirect('/home');
            }, 3000);
        })
        .catch(error => {
            errorHandler(error);
            notify('errorBox', 'Email is already taken.');
            clearFields('formRegister');
        });
    });

    this.get('/login', function(context) {
        extendContext(context)
        .then(function() {
            this.partial('../templates/login.hbs');
        })
    });

    this.post('/login', function(context) {
        const {email, password} = context.params;
        if(!validateEmail(email) || (password.length < 1)) {
            notify('errorBox', 'Invalid email/password.');
            clearFields('formLogin');
            return;
        }
        login(email, password)
        .then(userData => {
            const {user: {uid, email}} = userData;
            const data = JSON.stringify({uid, email});
            saveUserData(data);
            notify('infoBox', 'Login successful.');
            setTimeout(() => {
                this.redirect('/home');
            }, 3000);
        })
        .catch(error => {
            errorHandler(error);
            notify('errorBox', 'Invalid email/password');
            clearFields('formLogin');
        });
    });

    this.get('/logout', function(context) {
        logout()
        .then(() => {
            clearData();
            notify('infoBox', 'Logout successful.');
            setTimeout(() => {
                this.redirect('/login');
            }, 3000);
        })
        .catch(error => errorHandler(error));
    });

    this.get('/create', function(context) {
       extendContext(context)
       .then(function() {
           this.partial('../templates/createDestination.hbs');
       })
    });

    this.post('/create', function(context) {
       const {destination, city, duration, departureDate, imgUrl} = context.params;
       const creater = getUserData().uid;
       if((destination === '' || city === '' || duration === '' || departureDate === '' || imgUrl === '') || (Number(duration) < 1 || Number(duration) > 100)) {
            notify('errorBox', 'Invalid destination data.');
            return;
       }

       createDestination(destination, city, duration, departureDate, imgUrl, creater)
       .then(data => {
        notify('infoBox', 'Successfully added destination.');
            setTimeout(() => {
                this.redirect('/home');
            }, 1000);
       })
       .catch(error => {
        errorHandler(error);
        notify('errorBox', error.message);
        setTimeout(() => {
            this.redirect('/create');
        }, 1000)
       });
    });

    this.get('/details/:id', function(context) {
        const {id} = context.params;
        getById(id)
        .then(data => {
            context.isCreater = getUserData().uid === data.creater;
            data.departureDate = monthNumToText(data.departureDate);
            context.destination = data;
            extendContext(context)
            .then(function() {
                this.partial('../templates/details.hbs');
            });
        });
    });

    this.get('/edit/:id', function(context) {
        const {id} = context.params;
        getById(id)
        .then(data => {
            context.destination = data;
            extendContext(context)
            .then(function() {
                this.partial('../templates/editDestination.hbs')
            });
        })
    });


    this.post('/edit/:id', function(context) {
        const {id} = context.params;
        const {destination, city, duration, departureDate, imgUrl} = context.params;

        if((destination === '' || city === '' || duration === '' || departureDate === '' || imgUrl === '') || (Number(duration) < 1 || Number(duration) > 100)) {
            return;
        }
        getById(id)
        .then(data => {
            const {creater} = data;
            edit(id, destination, city, duration, departureDate, imgUrl, creater)
            .then(data => {
                notify('infoBox', 'Successfully edited destination.');
            setTimeout(() => {
                this.redirect(`#/details/${id}`);
            }, 3000);
            })
            .catch(error => errorHandler(error));
        })
    });

    this.get('/my-destinations', function(context) {
        getAll()
        .then(data => {
            context.destinations = getDestinationsFromCreater(data, getUserData().uid);
            console.log(context.destinations);
            extendContext(context)
            .then(function() {
                this.partial('../templates/detailsDashboard.hbs');
            });
        })

    });

    this.get('/delete/:id', function(context) {
        const {id} = context.params;
        deleteDestination(id)
        .then(data => {
            notify('infoBox', 'Destination deleted.');
            setTimeout(() => {
                this.redirect('#/my-destinations');
            }, 3000);
        })
        .catch(error => errorHandler(error));
    });
});

(() => {
    router.run('#/home');
})()