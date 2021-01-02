function attachEventsListeners() {
    console.log('TODO:...');
    //Set an eventListener to each of the buttons
    const daysField = document.getElementById("days");
    const hoursField = document.getElementById("hours");
    const minutesField = document.getElementById("minutes");
    const secondsField = document.getElementById("seconds");
    const daysButton = document.getElementById("daysBtn");
    const hoursButton = document.getElementById("hoursBtn");
    const minutesButton = document.getElementById("minutesBtn");
    const secondsButton = document.getElementById("secondsBtn");
    daysButton.addEventListener("click", function () {
        const days = daysField.value;
        hoursField.value = days * 24;
        minutesField.value = hoursField.value * 60;
        secondsField.value = minutesField.value * 60;
    });

    hoursButton.addEventListener("click", function () {
        const hours = hoursField.value;
        daysField.value = hours / 24;
        minutesField.value = hours * 60;
        secondsField.value = minutesField.value * 60;
    })

    minutesButton.addEventListener("click", function () {
        const minutes = minutesField.value;
        hoursField.value = minutes / 60;
        daysField.value = hoursField.value / 24;
        secondsField.value = minutes * 60;
    })

    secondsButton.addEventListener("click", function () {
        const seconds = secondsField.value;
        minutesField.value = seconds / 60;
        hoursField.value = minutesField.value / 60;
        daysField.value = hoursField.value / 24;
    })
    //Set the value of the other fields tot he converted value
}