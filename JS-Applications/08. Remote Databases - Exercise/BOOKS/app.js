const baseUrl = `https://books-18998.firebaseio.com`;
const tbody = document.querySelector('tbody');
const title = document.querySelector('#title');
const author = document.querySelector('#author');
const isbn = document.querySelector('#isbn');

const loadBtn = document.querySelector('#loadBooks');
loadBtn.addEventListener('click', getAllBooks)

const addBtn = document.querySelector('form > button');
addBtn.addEventListener('click', addBook);


function getAllBooks() {
    fetch(`${baseUrl}/Books.json`)
        .then(res => res.json())
        .then(data => {
            tbody.innerHTML = '';
            Object.keys(data).forEach(el => {
                if(data[el] === null) {
                    return;
                }
                    tbody.appendChild(createBookRow(data, el));
            });
        });
}

function createBookRow(data, el) {
    const tr = document.createElement('tr');
    tr.setAttribute('data-id', el);
    const title = createElement('td', data[el].title);
    const author = createElement('td', data[el].author);
    const isbn = createElement('td', data[el].Isbn);
    const buttonTD = createElement('td', '');
    const editBtn = createElement('button', 'Edit');
    const delBtn = createElement('button', 'Delete');
    tr.addEventListener('click', editForm);
    delBtn.addEventListener('click', deleteBook);
    editBtn.addEventListener('click', editBook);
    buttonTD.appendChild(editBtn);
    buttonTD.appendChild(delBtn);
    tr.appendChild(title);
    tr.appendChild(author);
    tr.appendChild(isbn);
    tr.appendChild(buttonTD);
    return tr;
}

function addBook(e) {
    e.preventDefault();
    const title = document.querySelector('#title').value;
    console.log(title);
    const author = document.querySelector('#author').value;
    const isbn = document.querySelector('#isbn').value;
    fetch(`${baseUrl}/Books.json`, {
        method: 'POST',
        body: JSON.stringify({
            "Isbn": isbn,
            "author": author,
            "title": title
        })
    })
        .then(() => clearFields())
        .catch(err => console.log(err));
}


function createElement(element, text) {
    let result = document.createElement(element);
    result.textContent = text;
    return result;
}

function deleteBook(e) {
    console.log('delete');
    let id = e.target.parentElement.parentElement.getAttribute('data-id');
    fetch(`${baseUrl}/Books/${id}.json`, {
        method: 'DELETE'
    })
        .then(() => e.target.parentElement.parentElement.remove())
        .catch(err => console.log(err));
}

function editForm(e) {
    if(e.target.tagName === 'BUTTON') {
        return;
    }
    let bookTitle = e.target.parentElement.children[0].textContent;
    let bookAuthor = e.target.parentElement.children[1].textContent;
    let bookIsbn = e.target.parentElement.children[2].textContent;
    title.value = bookTitle;
    author.value = bookAuthor;
    isbn.value = bookIsbn;
}

function editBook(e) {
    let id = e.target.parentElement.parentElement.getAttribute('data-id');
    fetch(`${baseUrl}/Books/${id}.json`, {
        method: 'PUT',
        body: JSON.stringify({
            "Isbn": isbn.value,
            "author": author.value,
            "title": title.value
        })})
            .then(() => clearFields())
            .catch(err => console.log(err))
}

function clearFields() {
    title.value = '';
    author.value = '';
    isbn.value = '';
}