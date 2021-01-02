function solve() {

    //TODO...
    let buttons = document.getElementsByTagName("button");
    let numberButtons = Array.from(document.querySelectorAll("button")).filter(element => buttonIsNumber(element));
    let operandButtons = Array.from(document.querySelectorAll("button")).filter(element => isOperand(element.value));
    console.log(operandButtons);
    let equalsButton = Array.from(document.querySelectorAll("button")).filter(element => element.value === '=');
    let clearButton = document.getElementsByClassName("clear")[0];

    numberButtons.forEach(element => element.addEventListener("click", function () {
        document.getElementById("expressionOutput").textContent += element.textContent;
    }));
    operandButtons.forEach(element => element.addEventListener("click", function () {
        document.getElementById("expressionOutput").textContent += ` ${element.textContent} `
    }));
    equalsButton[0].addEventListener("click", function () {
        //Get the expression
        let expression = document.getElementById("expressionOutput").textContent;
        let result = document.getElementById("resultOutput");
        //Check if it is a valid expression
        if(isValid(expression)) {
            //If it is compute the expression
            console.log(computeExpression(expression));
            result.textContent = computeExpression(expression);
        }
        //If it isn't return NaN
        else {
            result.textContent = 'NaN';
            console.log("success");
        }
    });
    clearButton.addEventListener("click", clearField());
    
    function buttonIsNumber(element) {
        if(element.value !== '/' && element.value !== '*'
            && element.value !== '-' && element.value !== '+' && element.value !== '=' && element.value !== "Clear") {
            return true;
        }
        return false;
    }
    function isValid(expression) {
        let elements = expression.split(' ');
        elements = elements.filter(element => element);
        console.log(elements);
        let first = Number(elements[0]);
        let second = Number(elements[2]);
        if(!isNaN(first) && isOperand(elements[1]) && !isNaN(second)) {
            return true;
        }
        return false;
    }

    function isOperand(sign) {
        if(sign === '+' || sign === '-' || sign === 'x' || sign === '/') {
            return true;
        }
        return false;
    }

    function computeExpression(expression) {
        let elements = expression.split(' ');
        let first = Number(elements[0]);
        let second = Number(elements[2]);
        switch(elements[1]) {
            case '+':
                return first + second;
            case '-':
                return first - second;
            case 'x':
                return first * second;
            default:
                return first / second;
        }
    }
    function clearField() {
        document.getElementById("expressionOutput").textContent = "";
        document.getElementById("resultOutput").textContent = "";
    }
}
    

