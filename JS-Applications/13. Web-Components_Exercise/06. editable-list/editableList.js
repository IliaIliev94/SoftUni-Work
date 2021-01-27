import {createListElement, removeListElement} from './helper.js';

class EditableList extends HTMLElement {
    constructor() {
        super();
        this.attachShadow({mode: 'open'});
        let editableListTemplate = document.getElementById('editable-list-template').content.cloneNode(true);
        editableListTemplate.querySelector('.editable-list-add-item')
        .addEventListener('click', createListElement);
        this.shadowRoot.addEventListener('click', removeListElement);
        this.shadowRoot.appendChild(editableListTemplate);
    }
}


customElements.define('editable-list', EditableList);