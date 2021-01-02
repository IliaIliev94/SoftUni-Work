function addItem() {
    const list = document.createElement("li");
    let text = document.getElementById("newItemText").value;
    list.textContent = text;
    document.getElementById("items").appendChild(list);
}