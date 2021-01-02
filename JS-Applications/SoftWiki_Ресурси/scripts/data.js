const auth = firebase.auth();
const baseUrl = `https://softwiki-ae61c-default-rtdb.firebaseio.com/`;

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

async function createArticle(title, category, content, creater) {
    let url = `${baseUrl}/articles.json`;
    let res = await post(url, {title, category, content, creater});
    return res;
}

async function getAll() {
    let url = `${baseUrl}/articles.json`;
    let res = await get(url);
    return objectToArray(res);
}

async function getById(id) {
    let url = `${baseUrl}/articles/${id}.json`;
    let res = await get(url);
    return {id, ...res};
}

async function edit(id, creater, content, category, title) {
    const url = `${baseUrl}/articles/${id}.json`;
    return patch(url, {creater, content, category, title});
}

async function deleteArticle(id) {
    const url = `${baseUrl}/articles/${id}.json`;
    return deleteRequest(url);
}


