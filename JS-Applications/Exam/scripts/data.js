const auth = firebase.auth();
const baseUrl = `https://destinations-exam-3c840-default-rtdb.firebaseio.com/`;

async function request(url, method, body) {
    let options = {method};

    if(body) {
        Object.assign(options, {
            body: JSON.stringify(body)
        });
    };
    let res = await fetch(url, options);

    let data = await res.json();

    return data
};

async function get(url) {
    return request(url, 'GET');
};

async function post(url, body) {
    return request(url, 'POST', body);
}

async function patch(url, body) {
    return request(url, 'PUT', body);
}

async function deleteRequest(url) {
    return request(url, 'DELETE');
}

function register(email, password) {
    return auth.createUserWithEmailAndPassword(email, password);
}

function login(email, password) {
    return auth.signInWithEmailAndPassword(email, password);
}

function logout() {
    return auth.signOut();
}

async function createDestination(destination, city, duration, departureDate, imgUrl, creater) {
    let url = `${baseUrl}/destinations.json`;
    let res = await post(url, {destination, city, duration, departureDate, imgUrl, creater});
    return res;
}

async function getAll() {
    let url = `${baseUrl}/destinations.json`;
    let res = await get(url);
    return objectToArray(res);
}

async function getById(id) {
    let url = `${baseUrl}/destinations/${id}.json`;
    let res = await get(url);
    return {id, ...res};
}

async function edit(id, destination, city, duration, departureDate, imgUrl, creater) {
    const url = `${baseUrl}/destinations/${id}.json`;
    return patch(url, {destination, city, duration, departureDate, imgUrl, creater});
}

async function deleteDestination(id) {
    const url = `${baseUrl}/destinations/${id}.json`;
    return deleteRequest(url);
}


