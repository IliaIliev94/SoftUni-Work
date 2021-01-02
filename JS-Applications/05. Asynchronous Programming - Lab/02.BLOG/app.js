function attachEvents() {
    const loadBtn = document.querySelector('#btnLoadPosts');
    const select = document.querySelector('#posts');
    loadBtn.addEventListener('click', function () {
        select.innerHTML = '';
        const url = `https://blog-apps-c12bf.firebaseio.com/posts.json`;
        fetch(url)
            .then(res => res.json())
            .then(data => {
                Object.keys(data).forEach(key => {
                    let option = document.createElement('option');
                    option.value = key;
                    option.textContent = data[key]["title"];
                    select.appendChild(option);
                });
            });
    });
    const viewBtn = document.querySelector('#btnViewPost');
    const postTitle = document.querySelector('#post-title');
    const postBody = document.querySelector('#post-body');
    viewBtn.addEventListener('click', function () {
        const comments = document.querySelector('#post-comments');
        const postKey = select.value;
        getData(postKey)
            .then(data => {
                comments.innerHTML = data.map(comment => `<li>${comment["text"]}</li>`).join('');
            });
    });

    async function getData(postKey) {
        let response = await fetch(`https://blog-apps-c12bf.firebaseio.com/posts/${postKey}.json`);
        let postData = await response.json();
        displayPost(postData);
        let commentsResponse = await fetch(`https://blog-apps-c12bf.firebaseio.com/comments.json`);
        let comments = await commentsResponse.json();
        return Object.values(comments).filter(comment => comment["postId"] === postData["id"])
    }

    function displayPost(postData) {
        postTitle.textContent = postData["title"];
        postBody.textContent = postData["body"];
    }
}

attachEvents();