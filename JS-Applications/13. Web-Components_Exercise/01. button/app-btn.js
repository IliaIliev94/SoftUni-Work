class CustomButton extends HTMLElement {
    constructor() {
        super();
        this.attachShadow({mode: 'open'});
        let template = document.getElementById('app-button');
        let newTemplate = template.content.cloneNode(true);
        newTemplate.children[1].textContent = this.getAttribute('text');
        newTemplate.children[1].classList.add(this.getAttribute('type'));
        this.shadowRoot.appendChild(newTemplate);
    }

    
}

customElements.define('custom-button', CustomButton);