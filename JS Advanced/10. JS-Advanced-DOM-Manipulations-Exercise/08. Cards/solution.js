function solve() {
   // TODO...
    const playerOneCards = document.getElementById("player1Div");
    let playerOneCard;
    let playerOneClicks = 0;
    playerOneCards.addEventListener("click", function (e) {
        playerOneClicks++;
        e.target.src = "images/whiteCard.jpg"
        document.getElementsByTagName("span")[0].textContent = e.target.name;
        playerOneCard = e.target;
        if(playerTwoClicks === playerOneClicks) {
            let playerOneValue = Number(document.getElementsByTagName("span")[0].textContent);
            let playerTwoValue = Number(document.getElementsByTagName("span")[2].textContent);
            if(playerOneValue > playerTwoValue) {
                e.target.style.border = "2px solid green";
                playerTwoCard.style.border = "2px solid red";
            }
            else if (playerOneValue < playerTwoValue) {
                e.target.style.border = "2px solid red";
                playerTwoCard.style.border = "2px solid green";
            }
            document.getElementById("history").textContent += '[' + playerOneValue + ' vs ' + playerTwoValue + ']' + ' ';
            document.getElementsByTagName("span")[0].textContent = "";
            document.getElementsByTagName("span")[2].textContent = "";
        }
    });

    const playerTwoCards = document.getElementById("player2Div");
    let playerTwoCard;
    let playerTwoClicks = 0;
    playerTwoCards.addEventListener("click", function (e) {
        playerTwoClicks++;
        e.target.src = "images/whiteCard.jpg";
        document.getElementsByTagName("span")[2].textContent = e.target.name;
        playerTwoCard = e.target;
        if(playerOneClicks === playerTwoClicks) {
            let playerOneValue = Number(document.getElementsByTagName("span")[0].textContent);
            let playerTwoValue = Number(document.getElementsByTagName("span")[2].textContent);
            if(playerOneValue > playerTwoValue) {
                e.target.style.border = "2px solid red";
                playerOneCard.style.border = "2px solid green";
            }
            else if (playerOneValue < playerTwoValue) {
                e.target.style.border = "2px solid green";
                playerOneCard.style.border = "2px solid red";
            }
            document.getElementById("history").textContent += '[' + playerOneValue + ' vs ' + playerTwoValue + ']' + ' ';
            document.getElementsByTagName("span")[0].textContent = "";
            document.getElementsByTagName("span")[2].textContent = "";
        }
    });
}