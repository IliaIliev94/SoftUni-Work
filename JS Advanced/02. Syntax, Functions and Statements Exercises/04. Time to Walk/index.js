function calculateDistance(numberOfSteps, stepLength, studentSpeed) {
    const meters = numberOfSteps * stepLength;
    let hours = meters / (studentSpeed * 1000);
    let minutesForRest = Math.floor(meters / 500);
    hours += minutesForRest / 60;
    let minutes = hours % 1 * 60;
    hours = Math.floor(hours);
    let seconds = Math.round(minutes % 1 * 60);
    minutes = Math.floor(minutes);
    let printHours = () => {
        if(hours < 10) {
            return '0' + hours;
        }
        return hours;
    }
    let printMinutes = () => {
        if(minutes < 10) {
            return '0' + minutes;
        }
        return minutes;
    }
    let printSeconds = () => {
        if(seconds < 10) {
            return '0' + seconds;
        }
        return seconds;
    }

    console.log(`${printHours()}:${printMinutes()}:${printSeconds()}`);
}

calculateDistance(2564, 0.70, 5.5);