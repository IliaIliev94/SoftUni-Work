function solve() {
    let button = document.getElementsByTagName("button")[0];
    button.addEventListener("click", function() {
        let name = formatName(document.getElementsByTagName("input")[0].value);
        let list = document.getElementsByTagName("ol")[0].children;
        let text = list[name.charCodeAt(0) - 65].textContent;
        addName(list, text, name);
    });

    function formatName(name) {
        return name.toUpperCase()[0] + name.substr(1, name.length - 1).toLowerCase()
    }

    function addName(list, text, name) {
        if(text === "") {
            list[name.toUpperCase().charCodeAt(0) - 65].textContent += name;
        }
        else {
            let names = [text, name];
            list[name.toUpperCase().charCodeAt(0) - 65].textContent = names.join(", ");
        }
    }
}
