function lockedProfile() {
    console.log('TODO...')
    //For each div profile button add an event listener
    const buttons = Array.from(document.getElementsByTagName("button"));
    buttons.forEach(element => element.addEventListener("click", () => hideShowContentDiv(element)));

    function hideShowContentDiv(element) {
        let isChecked = element.parentElement.children[4].checked;
        //When the button is clicked check if the profile is unlocked
        if(isChecked) {
            //If it is unlocked check if the display of the information div is none
            let informationDiv = element.previousElementSibling;
            //If it is show it
            if(informationDiv.style.display !== "block") {
                showDiv(informationDiv, element)
            }
            //If not hide it
            else {
                hideDiv(informationDiv, element)
            }
        }
    }

    function showDiv(informationDiv, element) {
        informationDiv.style.display = "block";
        element.textContent = "Hide it";
    }

    function hideDiv(informationDiv, element) {
        informationDiv.style.display = "none";
        element.textContent = "Show more";
    }
}