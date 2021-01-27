function createElement(name, text, className) {
    let result = document.createElement(name);
    result.textContent = text;
    if(className !== undefined) {
        result.className = className;
    }
   
    return result;
};

export function createListElement(e) {
    let text = e.target.previousElementSibling.value;
    if(text === '') {
        alert('Can\'t add empty item!');
        return;
    }
    let li = createElement('li', '');
    let p = createElement('p', text, 'editable-list-item-value');
    let button = createElement('button', e.target.parentElement.previousElementSibling
    .children[0].children[1].textContent, `editable-list-remove-item icon`);
    li.appendChild(p);
    li.appendChild(button);
    e.target.parentElement.previousElementSibling.appendChild(li);
};

export function removeListElement(e) {
    if(e.target.className !== 'editable-list-remove-item icon') {
        return;
    }
    e.target.parentElement.remove();
}