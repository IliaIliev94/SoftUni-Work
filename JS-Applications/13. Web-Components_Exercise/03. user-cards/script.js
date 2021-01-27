class UserCard extends HTMLElement {
    constructor() {
        super();
        this.attachShadow({mode: 'open'});
        let userCardTemplate = document.getElementById(`user-card-template`).content.cloneNode(true);
        userCardTemplate.querySelector('img').src = this.getAttribute('avatar');
        userCardTemplate.querySelector('h3').textContent = this.getAttribute('name');
        this.shadowRoot.appendChild(userCardTemplate);
        this.shadowRoot.addEventListener('click', toggleCard);
    }
}

function toggleCard(e) {
    if(e.target.tagName !== 'BUTTON') {
        return;
    }
    console.log('ok');
    let cardInfo = e.target.previousElementSibling;

    if(cardInfo.style.display !== 'none') {
        cardInfo.style.display = 'none';
        e.target.textContent = 'Show Info';
    }
    else {
        cardInfo.style.display = 'block';
        e.target.textContent = 'Hide Info';
    }
}

customElements.define('user-card', UserCard);