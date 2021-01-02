const routes = {
        'home': 'home-template',
        "login": 'login-form-template',
        'register': 'register-form-template',
        'add-movie': 'add-movie-template',
        'details': 'details-movie-template',
        'edit': 'edit-movie-template'
}


const router = async(fullpath) => {
    let [path, id] = fullpath.split('/');
    console.log(path);
    console.log(id);
    let app = document.getElementById('app');
    let templateData = authService.getData();
    switch(path){
        case 'home':
            templateData.movies = await moviesService.getAll();
            console.log(templateData.movies)
            break;
        case 'logout':
            authService.logOut();
            return navigate('home');
        case 'details':
            let movieDetails = await moviesService.getOne(id);
            Object.assign(templateData, movieDetails, {id});
        case 'edit':
            let test = await moviesService.getOne(id);
            Object.assign(templateData, test, {id});
        default:
            break;
    }
    const template = Handlebars.compile(document.getElementById(routes[path]).innerHTML);
    app.innerHTML = template(templateData);
};

const navigate = (path) => {
    history.pushState({}, '', '/' + path);
    router(path);
}