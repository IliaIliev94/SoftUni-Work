function extendContext(context) {
    context.isLoggedIn = isLoggedIn();
    context.email = context.isLoggedIn ? getUserData().email : '';
    return context.loadPartials({
        'header': '../partials/header.hbs',
        'footer': '../partials/footer.hbs',
        'destination': '../partials/destination.hbs',
        'myDestination': '../partials/myDestination.hbs'
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

function notify(type, message) {
    const notification = document.getElementsByClassName(type)[0];
    notification.style.display = 'initial';
    notification.textContent = message;
    notification.addEventListener('click', function(e) {
        e.target.style.display = 'none';
    })
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

function getDestinationsFromCreater(destinations, createrId) {
    let result = [];

    for(var destination of destinations) {
        console.log(destination.creater);
        console.log(createrId)
        if(destination.creater === getUserData().uid) {
            result.push(destination);
        }
    }
    return result;
}

const datesObject = {
    '01': 'January',
    '02': 'Febuary',
    '03': 'March',
    '04': 'April',
    '05': 'May',
    '06': 'June',
    '07': 'July',
    '08': 'August',
    '09': 'September',
    '10': 'October',
    '11': 'November',
    '12': 'December'
}

function monthNumToText(date) {
    const parsedDate = date.split('-');
    const month = datesObject[parsedDate[1]];
    return `${parsedDate[2]} ${month} ${parsedDate[0]}`;
}

function validateEmail(email) {
    const re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}

function clearFields(formId) {
    let form = document.getElementById(formId);
    console.log(form.children)
    Array.from(form.children).forEach(child => {
        if(child.tagName = 'INPUT' && child.type !== 'submit') {
            child.value = '';
        }
    })
}
