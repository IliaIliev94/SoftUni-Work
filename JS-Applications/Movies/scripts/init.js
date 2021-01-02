
function addEventListeners() {
    const template = document.getElementById('navigation-template').innerHTML;
    const movieTemplate = document.getElementById('movie-card-template').innerHTML
    Handlebars.registerPartial('navigation-template', template);
    Handlebars.registerPartial('movie-card', movieTemplate);
    navigate('home');
}

function navigateHandler(e) {
    console.log('yes');

    e.preventDefault();

    if(e.target.tagName !== 'A' && e.target.tagName !== 'BUTTON') {
        return;
    }
    let link = e.target.href;
    if(e.target.tagName === 'BUTTON') {
        link = e.target.parentElement.href;
    }
    let url = new URL(link);
    navigate(url.pathname.slice(1));
}

function onLoginSubmit(e) {
    e.preventDefault();
    let formData = new FormData(document.forms["login-form"]);
    let email = formData.get('email');
    let password = formData.get('password');
    authService.logIn(email, password)
    .then(data => {
        navigate('home');
    });
}

function onMovieSubmit(e) {
    e.preventDefault();
    let formData = new FormData(document.forms["add-movie-form"]);
    let title = formData.get('title');
    let description = formData.get('description');
    let imageURL = formData.get('imageUrl');
    moviesService.add({"title": title, "description": description, "imageUrl": imageURL})
    .then(data => {
        navigate('home');
    });
}

function deleteMovie(e) {
    e.preventDefault();
    let id = e.target.dataset.id;
    moviesService.deleteMovie(id)
    .then(res => {
        navigate('home');
    });
}

function onEditMovieSubmit(e, id) {
    e.preventDefault();
    let formData = new FormData(document.forms['edit-movie-form']);
    let title = formData.get('title');
    let description = formData.get('description');
    console.log(description);
    let imageUrl = formData.get('imageUrl');

    moviesService.editMovie(id, {
        title,
        description,
        imageUrl,
    })
    .then(res => {
        navigate(`details/${id}`);
    })
}

addEventListeners();