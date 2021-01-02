function solve() {
  //TODO...
    let links = document.getElementsByClassName("link-1");
    for(let i = 0; i < links.length; i++) {
        links[i].addEventListener("click", function() {
            let text = links[i].lastElementChild.textContent.split(" ");
            text[1] = Number(text[1]) + 1;
            links[i].lastElementChild.textContent = text.join(" ");
        });
    }

}