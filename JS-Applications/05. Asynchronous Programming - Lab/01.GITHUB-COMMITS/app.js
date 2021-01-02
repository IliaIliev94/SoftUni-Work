function loadCommits() {
    // Try it with Fetch API
    const username = document.querySelector('#username').value;
    const repo = document.querySelector('#repo').value;
    const url = `https://api.github.com/repos/${username}/${repo}/commits`;
    const ul = document.querySelector('#commits');
    let response = 400;
    let responseText = '';
    fetch(url)
        .then(res => {
            response = res.status;
            responseText = res.statusText;
            return res.json();
        })
        .then(data => {
            if(response === 200) {
                ul.innerHTML = data.map(el =>
                    `<li>${el["commit"]["author"]["name"]}: ${el["commit"]["message"]}</li>`).join('');
            }
            else {
                ul.innerHTML = `<li>Error: ${response} ${responseText}</li>`
            }
        })
        .catch((err) => {
            console.log(err);
        });
}