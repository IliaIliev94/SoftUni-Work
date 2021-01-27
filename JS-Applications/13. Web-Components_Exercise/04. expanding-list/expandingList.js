class ExpandingList extends HTMLLIElement {
    constructor() {
        super();
        console.log('ok')
        this.setAttribute('class', 'closed');
        Array.from(this.children).forEach(element => element.style.display = 'none');
        this.addEventListener('click', function(e) {
            if(e.target !== this) {
                return;
            }
            if(e.target.className === 'closed') {
                e.target.className = 'open';
                Array.from(e.target.children).forEach(element => element.style.display = 'block');
            }
            else {
                e.target.className = 'closed';
                Array.from(e.target.children).forEach(element => element.style.display = 'none');
            }
            console.log('ok')
        });
    }
}

customElements.define('expanding-list', ExpandingList, {extends: 'li'});