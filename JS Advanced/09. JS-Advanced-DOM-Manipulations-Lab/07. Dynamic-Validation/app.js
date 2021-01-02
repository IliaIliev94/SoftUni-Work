function validate() {
    console.log('TODO:...');
    const emailFormat = /\w+@\w+.\w+/g;
    let email = document.getElementById("email");
    email.addEventListener("change", function() {
        let emailText = email.value;
        if(!emailText.match(emailFormat)) {
            email.classList.add("error");
        }
        else {
            email.classList.remove("error");
        }
    });
}