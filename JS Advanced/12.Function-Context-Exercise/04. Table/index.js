function solve(){
   // TODO
    let tableBody = Array.from(document.querySelectorAll('tr'));
    let lastClicked = null;
    tableBody.forEach(element => element.addEventListener("click", function() {
        if(lastClicked && lastClicked !== element) {
            lastClicked.style.backgroundColor = '';
        }
        lastClicked = element;
        let color = element.style.backgroundColor;
        if(color === 'rgb(65, 63, 94)') {
            element.style.backgroundColor = '';
            lastClicked = null;
        }
        else {
            element.style.backgroundColor= '#413f5e';
        }
    }));
}
