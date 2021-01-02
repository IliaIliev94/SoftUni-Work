function solve() {
   //TODO...
    //Add event listener to send button
    let sendButton = document.getElementById("send");
    sendButton.addEventListener("click", function () {
        //Create a new div element with my message class
        let newMessage = createNewMessageDiv();
        //Get the text from the chat input and add it as textContent to the div
        newMessage.textContent = document.getElementById("chat_input").value;
        //Append the div to the chat messages div
        document.getElementById("chat_messages").appendChild(newMessage);
        clearTypingField();
    });

    function createNewMessageDiv() {
        let newMessage = document.createElement("div");
        newMessage.setAttribute("class", "message my-message");
        return newMessage;
    }

    function clearTypingField() {
        document.getElementById("chat_input").value = "";
    }
}


