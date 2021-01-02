let firebaseConfig = {
    apiKey: "AIzaSyDbm5UOycSdp2sumBUzRNFZ5avu8bcX5u8",
    authDomain: "books-18998.firebaseapp.com",
    databaseURL: "https://books-18998.firebaseio.com",
    projectId: "books-18998",
    storageBucket: "books-18998.appspot.com",
    messagingSenderId: "28442566358",
    appId: "1:28442566358:web:125b8041f20425fb013377",
    measurementId: "G-2EXNTEYCHX"
};
// Initialize Firebase
firebase.initializeApp(firebaseConfig);
firebase.analytics();



const registerBtn = document.querySelector('#register');
const loginBtn = document.querySelector('#login');
const logoutBtn = document.querySelector('#log-out');

registerBtn.addEventListener('click', register);
loginBtn.addEventListener('click', login);
logoutBtn.addEventListener('click', logout);

function register(event) {
    event.preventDefault();
    const email = document.querySelector('#register-email').value;
    const password = document.querySelector('#register-password').value;
    firebase.auth().createUserWithEmailAndPassword(email, password)
    .catch(function(error) {
        // Handle Errors here.
        console.log(error);
    });
}

function login(event) {
    event.preventDefault();
    const email = document.querySelector('#login-email').value;
    const password = document.querySelector('#login-password').value;
    firebase.auth().signInWithEmailAndPassword(email, password)
        .then(res => {
            document.querySelector('#welcome').textContent = `Hello, ${res.user.email}`;
            document.querySelector('#log-out').setAttribute('style', 'display: initial;');
            document.querySelectorAll('form').forEach(el => el.style.display = 'none');
        })
        .catch(function(error) {
        console.log(error);
    });
}

function logout() {
    firebase.auth().signOut().then(function() {
        document.querySelector('#welcome').textContent = `Hello`;
        document.querySelector('#log-out').setAttribute('style', 'display: none;');
        document.querySelectorAll('form').forEach(el => el.style.display = '');
    })
        .catch(function(error) {
            console.log(error);
        });

}
