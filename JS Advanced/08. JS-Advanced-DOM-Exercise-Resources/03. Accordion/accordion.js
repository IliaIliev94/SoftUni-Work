function toggle() {
    const button = document.getElementsByClassName("button")[0];
    const element = document.getElementById("extra");
    if(element.style.display !== "block") {
        element.setAttribute("style", "display: block");
        button.textContent = "Less";
    }
    else {
        element.setAttribute("style", "display: none");
        button.textContent = "More";
    }
}