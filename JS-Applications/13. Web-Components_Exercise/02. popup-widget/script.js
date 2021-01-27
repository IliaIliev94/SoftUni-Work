class PopupWidget extends HTMLElement {
    constructor() {
        super();
        this.attachShadow({mode: 'open'});
        let popUpTemplate = document.getElementById('popup-template').content.cloneNode(true);
        popUpTemplate.children[1].children[0].children[0].src = this.getAttribute('source-image');
        popUpTemplate.children[1].children[0].children[0].alt = this.getAttribute('alternative-text');
        popUpTemplate.children[1].children[1].textContent = this.getAttribute('popup-text');
        this.shadowRoot.appendChild(popUpTemplate);
    }
}

customElements.define('popup-widget', PopupWidget);