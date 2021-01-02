function create(data) {
    return firebase.firestore().collection('destinations').add(data);
}

function getAll() {
    return firebase.firestore().collection('destinations').get();
}

function getById(id) {
    return firebase.firestore().collection('destinations').doc(id).get();
}

function deleteEntity(id) {
    return firebase.firestore().collection('destinations').doc(id).delete();
}

function update(id, data) {
    return firebase.firestore().collection('destinations').doc(id).update(data);
}