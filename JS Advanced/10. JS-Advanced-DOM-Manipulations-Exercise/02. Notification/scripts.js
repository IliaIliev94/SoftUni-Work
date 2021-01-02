function notify(message) {
    console.log('TODO:...');
    //Add an event listener to the get notified button
    const notification = document.getElementById("notification");
    notification.textContent = message;
    //When the button is clicked set the display of the notification div to initial for 2 secs
    notification.style.display = "block";
    //After that set the display to none again
    setTimeout(() => notification.style.display = "none", 2000);
}