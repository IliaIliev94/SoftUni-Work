function deleteByEmail() {
    //Get the email from the input
    let email = document.querySelector("input[name = 'email']").value;
    console.log(email);
    //Search the table for the email
    let emails = document.getElementsByTagName('tbody')[0];
    let isFound = false;
    for(let i = 0; i < emails.children.length; i++) {
        if(email === emails.children[i].lastElementChild.textContent) {
            console.log("true");
            emails.children[i].remove();
            isFound = true;
            document.getElementById("result").textContent = "Deleted.";
        }
    }
    //If the table has that email delete the row from the table
    if(!isFound) {
        document.getElementById("result").textContent = "Not found.";
    }
    //If not display an error
}