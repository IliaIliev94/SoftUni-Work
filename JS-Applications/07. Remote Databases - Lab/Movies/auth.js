// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
let firebaseConfig = {
    apiKey: "AIzaSyDW5HEauvpR_FLWp9Os9WPL8fViw9ylA3g",
    authDomain: "test-8685f.firebaseapp.com",
    databaseURL: "https://test-8685f.firebaseio.com",
    projectId: "test-8685f",
    storageBucket: "test-8685f.appspot.com",
    messagingSenderId: "605939310407",
    appId: "1:605939310407:web:8265740984b9ec0895f662",
    measurementId: "G-PRK61JC50C"
};

// Initialize Firebase
firebase.initializeApp(firebaseConfig);
firebase.analytics();
const btn = document.querySelector('button');
const subHeader = document.querySelector('#sub-header');
const loginForm = document.querySelectorAll('.login-form')[0];
btn.addEventListener('click', onUserLogin);

function onUserLogin(e) {
    const username = document.querySelector('#username').value;
    const password = document.querySelector('#password').value;
    const auth = firebase.auth();
    auth.signInWithEmailAndPassword(username, password)
        .then(res => {
            console.log(res);
            console.log('Successfully logged in');
            subHeader.textContent = `Hello, ${res.user.email}`;
            loginForm.style.display = 'none';
        })
        .catch(err => console.log('Error'));
}