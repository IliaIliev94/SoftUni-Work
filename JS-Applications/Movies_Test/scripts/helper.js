function loadPartials(context) {
    return context.loadPartials({
        'header': '../partials/header.hbs',
        'footer': '../partials/footer.hbs',
        'movie': '../partials/movie.hbs'
    });
}

function saveUserData(data) {
    const email = data.user.email;
    const uid = data.user.uid;
    localStorage.setItem('user', JSON.stringify({email: email, uid: uid}));
}

function getUserData() {
    const user =  localStorage.getItem('user');
    return user ? JSON.parse(user) : null;
}

function clearUserData() {
    localStorage.removeItem('user');
}

function checkifUserIsLoggedIn(context) {
    const user = getUserData();
    context.isLoggedIn = Boolean(user);
    context.email = user ? user.email : '';
}

function getAllMovies(url) {
    return fetch(url).then(res => res.json());
}


