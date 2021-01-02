function solve() {
  //TODO...
    let text = document.getElementById("input").textContent.split(".");
    let output = document.getElementById("output");
    let appendText = [];
    for(let i = 0; i < text.length; i++) {
        if(appendText.length === 3 || i === text.length - 1) {
            output.appendChild(createParagraph(appendText));
            appendText = [];
        }
        appendText.push(text[i] + ".");
    }
    
    function createParagraph(appendText) {
        let paragraph = document.createElement("p");
        paragraph.textContent = appendText.join("");
        return paragraph
    }
}

