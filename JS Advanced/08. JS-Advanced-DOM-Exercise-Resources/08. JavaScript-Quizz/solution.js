function solve() {
    let correctAnswers = 0;
    //TODO...
    //Add an event listener for each of the buttons
    let answers = document.getElementsByClassName("answer-text");
    for(let i = 0; i < answers.length; i++) {
        answers[i].addEventListener("click", function () {
            //When clicked if the button answer is correct increment the correctAnswers
            if(answers[i].textContent === 'onclick' || answers[i].textContent === 'JSON.stringify()'
                || answers[i].textContent === 'A programming API for HTML and XML documents') {
                correctAnswers++;
            }
            //Hide the current section and unhide the next if any
            answers[i].parentElement.parentElement.parentElement.parentElement.style.display = "none";
            if(answers[i].parentElement.parentElement.parentElement.parentElement.nextElementSibling !== undefined) {
                answers[i].parentElement.parentElement.parentElement.parentElement.nextElementSibling.style.display = "block";
            }
            if(answers[i].parentElement.parentElement.parentElement.parentElement.nextElementSibling.id === "results") {
                if(correctAnswers === 3) {
                    document.getElementById("results").firstElementChild.firstElementChild.textContent = "You are recognized as top JavasScript fan!";
                }
                else {
                    document.getElementById("results").firstElementChild.firstElementChild.textContent = `You have ${correctAnswers} right answers`;
                }
            }
        });
    }
}