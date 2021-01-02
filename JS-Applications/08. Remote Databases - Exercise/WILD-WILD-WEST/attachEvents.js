const baseUrl = ``;
function attachEvents() {
    const saveButton = document.querySelector('#save');
    console.log("TODO...");

    //When the page is loaded a get request should be sent to the server
    loadPlayers();

}

function loadPlayers() {
    const players = document.querySelector('#players');
    fetch(baseUrl)
        .then(res =>res.json())
        .then(data => {
            Object.keys(data).forEach(el => {
                players.appendChild(displayPlayer(data, el));
            });
        });
}

function displayPlayer(data, el) {
    let playerDiv = createElement('div', '', ['player']);
    let name = createElement('div', data[el].name);
    let money = createElement('div', data[el].money);
    let bullets = createElement('div', data[el].bullets);
    let buttonsDiv = createElement('div');
    let playBtn = createElement('button', 'Play', ['play']);
    playBtn.addEventListener('click', play());
    let delBtn = createElement('button', 'Delete', ['delete']);
    appendChildren(buttonsDiv, [playBtn, delBtn]);
    appendChildren(playerDiv, [name, money, bullets, buttonsDiv]);
    return playerDiv;
}

function createElement(element, text, classList) {
    let result = document.createElement(element);
    result.textContent = text;
    classList.forEach(classElement => result.classList.add(classElement));
    return result;
}

function appendChildren(parent, children) {
    children.forEach(child => parent.appendChild(child));
}