function attachEvents() {
    const sendBtn = document.querySelector('#submit');
    const refreshBtn = document.querySelector('#refresh');
    const url = `https://rest-messanger.firebaseio.com/messanger.json`;
    const messages = document.querySelector('#messages');

    sendBtn.addEventListener('click', sendMessage);

    refreshBtn.addEventListener('click', getMessages);

    function sendMessage() {
        const author = document.querySelector('#author').value;
        const content = document.querySelector('#content').value;
        let message = {
            "author": author,
            "content": content
        };
        fetch(url, {
            method: 'POST',
            body: JSON.stringify(message)
        })
            .then(res => res.json())
    }

    function getMessages() {
        messages.value = '';
        let messagesList = [];
        fetch(url)
            .then(res => res.json())
            .then(data => {
                Object.keys(data).forEach(msg => {
                    messagesList.push(`${data[msg]['author']}: ${data[msg]['content']}`);
                });
                messages.value = messagesList.join('\n');
            });
    }
}

attachEvents();