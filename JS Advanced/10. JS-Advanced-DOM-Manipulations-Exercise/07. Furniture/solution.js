function solve() {

  //TODO...
    const generateBtn = document.getElementsByTagName("button")[0];
    const table = document.getElementsByTagName("tbody")[0];
    generateBtn.addEventListener("click", function () {
        //Get the array object from the textarea and parse it
        const objectData = JSON.parse(document.getElementsByTagName("textarea")[0].value);
        //Create a new table row from the parsed data
        for(let i = 0; i < objectData.length; i++) {
            table.appendChild(createTableRow());
        }
    });
    const buyBtn = document.getElementsByTagName("button")[1];
    const boughtProducts = document.getElementsByTagName("textarea")[1];
    let products = [];
    let totalPrice = 0;
    let decorationSum = 0;
    buyBtn.addEventListener("click", function () {
        for(let i = 0; i < table.children.length; i++) {
            if(table.children[i].lastElementChild.firstElementChild.checked === true) {
                products.push(table.children[i].children[1].textContent);
                totalPrice += Number(table.children[i].children[2].textContent);
                decorationSum += Number(table.children[i].children[3].textContent);
            }
        }
        boughtProducts.textContent = `Bought furniture: ${products.join(", ")}\nTotal price: ${totalPrice.toFixed(2)}\nAverage decoration factor: ${decorationSum / products.length}`;

    });
    function createTableRow() {
        const tableRow = document.createElement("tr");
        const image = document.createElement("td");
        const img = document.createElement("img");
        img.src = objectData[i].img;
        image.appendChild(img);
        tableRow.appendChild(image);
        const name = document.createElement("td");
        name.textContent = objectData[i].name;
        tableRow.appendChild(name);
        const price = document.createElement("td");
        price.textContent = objectData[i].price;
        tableRow.appendChild(price);
        const decoration = document.createElement("td");
        decoration.textContent = objectData[i].decFactor;
        tableRow.appendChild(decoration);
        const inputCell = document.createElement("td");
        const input = document.createElement("input");
        input.type = "checkbox";
        inputCell.appendChild(input);
        tableRow.appendChild(inputCell);
        return tableRow;
    }

}

[{"name": "Sofa", "img":
"https://res.cloudinary.com/maisonsdumonde/image/upload/q_auto,f_auto/w_200/img/ grey-3-seater-sofa-bed-200-13-0-175521_9.jpg", "price": 150, "decFactor": 1.2}]