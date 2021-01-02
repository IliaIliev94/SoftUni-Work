function solve() {
   //TODO...
    const searchButton = document.getElementById("searchBtn");
    const tableBody = document.getElementsByTagName("tbody")[0].children;
    let isFound = false;
    let tableRows = [];
    searchButton.addEventListener("click", function () {
        const searchValue = document.getElementById("searchField").value;
        document.getElementById("searchField").value = "";
        if(isFound) {
            tableRows.forEach(element => element.classList.remove("select"));
        }
        isFound = false;
        tableRows = [];
        for(let i = 0; i < tableBody.length; i++) {
            for(let j = 0; j < tableBody[i].children.length; j++) {
                if(tableBody[i].children[j].textContent.includes(searchValue)) {
                    isFound = true;
                    tableRows.push(tableBody[i]);
                    tableBody[i].classList.add("select");
                }
            }

        }
    });
}