function solve() {
    // ToDo
    const dropdownBtn = document.querySelector("#dropdown");
    const dropdownList = document.querySelector("#dropdown-ul");
    const boxBtn = document.querySelector("#box");
    dropdownBtn.addEventListener('click', toggleList);
    dropdownList.addEventListener("click", function(e) {
        boxBtn.style.backgroundColor = e.target.textContent;
    });

    function toggleList() {
        if(dropdownList.style.display !== "block") {
            dropdownList.style.display = "block";
        }
        else {
            dropdownList.style.display = "none";
        }
    }
}