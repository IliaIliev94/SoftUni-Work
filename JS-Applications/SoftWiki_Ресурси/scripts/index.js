const router = Sammy('#root', function() {

    this.use('Handlebars', 'hbs');
    this.get('/', function(context) {
        this.redirect('/home');
    })

    this.get('/home', function(context) {
        context.isLoggedIn = isLoggedIn();
        getAll()
        .then(data => {
            const sections = mapCategories(data);
            Object.assign(context, sections);
            extendContext(context)
            .then(function() {
                this.partial('../templates/home.hbs');
            });
        })
    })

    this.get('/register', function(context) {
        extendContext(context)
        .then(function() {
            this.partial('../templates/register.hbs');
        });
    });

    this.post('/register', function(context) {
        const {email, password, repeatPassword} = context.params;
        if(password != repeatPassword) {
            return;
        }
        register(email, password)
        .then(userData => {
            const {user: {uid, email}} = userData;
            const data = JSON.stringify({uid, email});
            saveUserData(data);
            this.redirect('/home');
        })
        .catch(error => errorHandler(error));
    });

    this.post('/login', function(context) {
        const {email, password} = context.params;
        login(email, password)
        .then(userData => {
            const {user: {uid, email}} = userData;
            const data = JSON.stringify({uid, email});
            saveUserData(data);
            this.redirect('/home');
        })
        .catch(error => errorHandler(error));
    });

    this.get('/logout', function(context) {
        logout()
        .then(() => {
            clearData();
            this.redirect('/home');
        })
        .catch(error => errorHandler(error));
    });

    this.get('/create', function(context) {
        context.isLoggedIn = isLoggedIn();
        extendContext(context)
        .then(function() {
            this.partial('../templates/createArticle.hbs');
        });
    });

    this.post('/create', function(context) {
        const {title, category, content} = context.params;
        const creater = getUserData().uid;
        createArticle(title, category, content, creater)
        .then(data => {
            this.redirect('/home');
        })
        .catch(error => console.log(error));
    });

    this.get('/details/:id', function(context) {
        context.isLoggedIn = isLoggedIn();
        const {id} = context.params;
        getById(id)
        .then(data => {
            context.article = data;
            context.isCreater = isCreater(data.creater);
            extendContext(context)
            .then(function() {
                this.partial('../templates/details.hbs');
            })
        })
        .catch(error => errorHandler(error));
    });

    this.get('/edit/:id', function(context) {
        context.isLoggedIn = isLoggedIn();
        const {id} = context.params;
        getById(id)
        .then(data => {
            context.article = data;
            extendContext(context)
            .then(function() {
                this.partial('../templates/editArticle.hbs');
            });
        })
        .catch(error => errorHandler(error));
    });


    this.post('/edit/:id', function(context) {
        const {id, title, content, category} = context.params;
        getById(id)
        .then(data => {
            console.log(data);
            const {creater} = data;
            edit(id, creater, content, category, title)
            .then(editData => {
                console.log('yes');
                this.redirect('/home');
            })
        })
        .catch(error => errorHandler(error));
    });

    this.get('/delete/:id', function(context) {
        const {id} = context.params;
        deleteArticle(id)
        .then(data => {
            this.redirect('/home');
        })
        .catch(error => errorHandler(error));
    });
});





(() => {
    router.run('#/home');
})()