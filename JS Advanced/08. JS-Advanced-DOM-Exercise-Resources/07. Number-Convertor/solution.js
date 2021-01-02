function solve() {
    //TODO...
    let button = document.getElementsByTagName("button")[0];
    let select = document.getElementById("selectMenuTo");
    createSelectOptions(select);
    button.addEventListener("click", function () {
        //Get the number to convert
        const number = document.getElementById("input").value;
        //Check whether to convert to decimal or binary
        const conversionOptions = document.getElementById("selectMenuTo");
        const conversionValue = conversionOptions.options[conversionOptions.selectedIndex].value;
        //Convert it
        let convertedNumber = convertNumber(conversionValue, number);
        //Display it in the result section
        document.getElementById("result").value = convertedNumber;
    });
    
    function createSelectOptions(select) {
        select.appendChild(createBinaryOption());
        select.appendChild(createHexadecimalOption());
    }
    
    function createBinaryOption() {
        let binary = document.createElement("option");
        binary.value = "binary";
        binary.textContent = "Binary";
        return binary;
    }
    
    function createHexadecimalOption() {
        let hexadecimal = document.createElement("option");
        hexadecimal.value = "hexadecimal";
        hexadecimal.textContent = "Hexadecimal";
        return hexadecimal;
    }
    
    function convertNumber(conversionValue, number) {
        let convertedNumber
        if(conversionValue === "binary") {
            convertedNumber = Number(number).toString(2);
        }
        else {
            convertedNumber = Number(number).toString(16).toUpperCase();
        }
        return convertedNumber;
    }
}