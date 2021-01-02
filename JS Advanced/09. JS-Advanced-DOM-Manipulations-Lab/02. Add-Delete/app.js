function addItem() {
    //TODO...
    const listElement = document.createElement("li");
    listElement.textContent = document.getElementById("newText").value;
    let deleteButton = document.createElement('a');
    deleteButton.href = "#";
    deleteButton.textContent = "[Delete]";
    deleteButton.addEventListener("click", () => deleteButton.parentElement.remove());
    listElement.appendChild(deleteButton);
    document.getElementById("items").appendChild(listElement);
}