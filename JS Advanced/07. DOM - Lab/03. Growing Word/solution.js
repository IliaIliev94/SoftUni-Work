function growingWord() {
    if(document.getElementsByTagName("p")[2].getAttribute("style") === null) {
        document.getElementsByTagName("p")[2].setAttribute("style", "font-size: 2px; color: blue");
    }
    else {
        let attributes = document.getElementsByTagName("p")[2].getAttribute("style").split(";");
        console.log(attributes);
        let fontSize = attributes[0].split(": ")[1];
        fontSize = fontSize.substr(0, fontSize.length - 2);
        console.log(fontSize);
        let color = attributes[1].split(": ")[1];

        document.getElementsByTagName("p")[2].setAttribute("style", `font-size: ${fontSize * 2}px; color: ${changeColor(color)}`);
    }
  function changeColor(initialColor) {
        let color;
        switch (color) {
            case "blue":
                color = "green";
                break;
            case "green":
                color = "red";
                break;
            default:
                color = "blue";
        }
      return color;
  }
}

