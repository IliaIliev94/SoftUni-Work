function stopwatch() {
    console.log('TODO:...');
    let startButton = document.getElementById("startBtn");
    let stopButton = document.getElementById("stopBtn");
    let intervalID;

    startButton.addEventListener("click", function () {
        let seconds = 0;
        document.getElementById("time").textContent = calculateTime(seconds);
        stopButton.disabled = false;
           intervalID = setInterval(function () {
                    seconds += 1;
                    document.getElementById("time").textContent = calculateTime(seconds);
            }, 1000);
    });

    stopButton.addEventListener("click", function () {
        clearInterval(intervalID);
        stopButton.disabled = true;
    });

    function calculateTime(seconds) {
        let minutes = Math.floor(seconds / 60);
        seconds = seconds % 60;
        return formatTime(seconds, minutes);

    };

    function formatTime(seconds, minutes) {
        if(seconds < 10 && minutes < 10) {
            return `0${minutes}:0${seconds}`
        }
        else if(seconds < 10) {
            return `${minutes}:0${seconds}`;
        }
        else if(minutes < 10) {
            return `0${minutes}:${seconds}`;
        }
        return `${minutes}:${seconds}`;
    };
}