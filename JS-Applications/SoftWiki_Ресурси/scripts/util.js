function extendContext(context) {
    context.isLoggedIn = isLoggedIn();
    return context.loadPartials({
        'header': '../partials/header.hbs',
        'footer': '../partials/footer.hbs',
        'article': '../partials/article.hbs'
    });
};

function saveUserData(data) {
    localStorage.setItem('user', data);
}

function getUserData() {
    return JSON.parse(localStorage.getItem('user'));
}

function clearData() {
    localStorage.removeItem('user');
}

function errorHandler(error) {
    console.log(error);
}

function isLoggedIn() {
    return Boolean(getUserData() !== null);
}

function objectToArray(data) {
    return Object.entries(data).map(([k, v]) => {
        return {'id':k, ...v};
    });
}

function isCreater(createrId){
    return createrId === getUserData().uid;
}

const categoryObject = {
    'Javascript': 'js',
    'JavaScript': 'js',
    'C#': 'csharp',
    'Java': 'java',
    'Python': 'python'
};

function mapCategories(data) {
    const result = {
        js: [],
        csharp: [],
        java: [],
        python: []
    }
    for(let article of data) {
        result[categoryObject[article.category]].push(article);
    }
    return result;
}
