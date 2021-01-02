function addItem() {
    console.log('TODO:...');
    let text = document.getElementById("newItemText").value;
    let value = document.getElementById("newItemValue").value;
    let option = createOption(text, value);
    document.getElementById("menu").appendChild(option);
    cleanFields();

    function createOption(textContent, value) {
        let option = document.createElement("option");
        option.textContent = text;
        option.value = value;
        return option;

    }

    function cleanFields() {
        document.getElementById("newItemText").value = "";
        document.getElementById("newItemValue").value = "";
    }

}