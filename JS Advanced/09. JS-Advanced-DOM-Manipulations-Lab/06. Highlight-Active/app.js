function focus() {
    console.log('TODO:...');
    let inputs = document.getElementsByTagName("input");
    for(let i = 0; i < inputs.length; i++) {
        inputs[i].addEventListener("focus", function() {
            inputs[i].parentElement.classList.add("focused");
        });
        inputs[i].addEventListener("blur", function () {
            inputs[i].parentElement.classList.remove("focused");
        });
    }
}