function solve() {
    //TODO...
    const table = document.querySelector("table");
    const checkBtn = document.querySelectorAll("button")[0];
    const inputs = Array.from(document.querySelectorAll("input"));
    const paragraph = document.querySelector("#check > p");
    const clearBtn = document.querySelectorAll("button")[1];
    checkBtn.addEventListener("click", sudomu);
    clearBtn.addEventListener("click", clear)

    function sudomu() {
        let isSudomu = isCorrect();
        if(isSudomu) {
            table.style.border = "2px solid green";
            paragraph.textContent = "You solve it! Congratulations!";
            paragraph.style.color = "green";
        }
        else {
            table.style.border = "2px solid red";
            paragraph.textContent = "NOP! You are not done yet..."
            paragraph.style.color = "red";
        }
    }

    function isCorrect() {
        const matrix = [
            [inputs[0].value, inputs[1].value, inputs[2].value],
            [inputs[3].value, inputs[4].value, inputs[5].value],
            [inputs[6].value, inputs[7].value, inputs[8].value]
        ];
        for(let i = 0; i < matrix.length; i++) {
            for(let j = 0; j < matrix[i].length; j++) {
                for(let k = j + 1; k < matrix[i].length; k++) {
                    if(matrix[i][j] === matrix[i][k]) {
                        return false
                    }
                    if(matrix[j][i] === matrix[k][i]) {
                        return false;
                    }
                }
            }
        }
        return true;
    }
    function clear() {
        inputs.forEach(element => element.value = "");
        table.style.border = "none";
        paragraph.textContent = "";
    }
}