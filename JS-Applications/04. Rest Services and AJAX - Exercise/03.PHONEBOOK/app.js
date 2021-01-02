function attachEvents() {
    const loadBtn = document.querySelector('#btnLoad');
    const createBtn = document.querySelector('#btnCreate');
    const ul = document.querySelector('#phonebook');
    loadBtn.addEventListener('click', function () {
        ul.textContent = '';
        const url = `https://phonebook-nakov.firebaseio.com/phonebook.json`;
        fetch(url)
            .then(res => res.json())
            .then(data => {
                Object.keys(data).forEach(contact => {
                    let delBtn = document.createElement('button');
                    delBtn.textContent = 'Delete';
                    delBtn.addEventListener('click', function(e) {
                        console.log(contact);
                        const deleteUrl = `https://phonebook-nakov.firebaseio.com/phonebook/${contact}.json`
                        fetch(deleteUrl, {
                            method: 'DELETE'
                        })
                            .then(res => res.json())
                        this.parentElement.remove();
                    });
                    let li = document.createElement('li');
                    li.textContent = `${data[contact]["person"]}: ${data[contact]["phone"]}`;
                    li.appendChild(delBtn);
                    ul.appendChild(li);
                });

            });
    });
    createBtn.addEventListener('click', function () {
        const personText = document.querySelector('#person').value;
        const phoneText = document.querySelector('#phone').value;
        const url = `https://phonebook-nakov.firebaseio.com/phonebook.json`;
        fetch(url, {
            method: 'POST',
            body: JSON.stringify({
                "person": personText,
                "phone": phoneText
            })
        })
            .then(res => res.json())
    });
}

attachEvents();