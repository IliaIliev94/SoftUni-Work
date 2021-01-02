function solve() {
    let currentStop = '';
    let stop = 'depot';
    const departBtn = document.querySelectorAll('input')[0];
    const arriveBtn = document.querySelectorAll('input')[1];
    const infoBox = document.querySelector('.info');
    function depart() {
        const url = `https://judgetests.firebaseio.com/schedule/${stop}.json`
        fetch(url)
            .then(res => res.json())
            .then(data => {
                currentStop = data["name"]
                infoBox.textContent = `Next stop ${currentStop}`;
                stop = data["next"];
            })
            .catch(err => {
                departBtn.disabled = true;
                arriveBtn.disabled = true;
                infoBox.textContent = 'Error';
            })
        departBtn.disabled = true;
        arriveBtn.disabled = false;
    }

    function arrive() {
        infoBox.textContent = `Arriving at ${currentStop}`;
        departBtn.disabled = false;
        arriveBtn.disabled = true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();