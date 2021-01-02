function getInfo() {
    const stopId = document.getElementById('stopId').value;
    const url = `https://judgetests.firebaseio.com/businfo/${stopId}.json`;
    const stopName = document.getElementById('stopName');
    const ul = document.getElementById('buses');
    ul.innerHTML = '';
    fetch(url)
        .then(res => res.json())
        .then(data => {
            stopName.textContent = data["name"];
            ul.innerHTML = Object.keys(data["buses"]).map(bus => `<li>Bus ${bus} arrives in ${data["buses"][bus]} minutes</li>`).join('')
        })
        .catch(err => {
            stopName.textContent = 'Error';
        });
    stopId.value = '';
}