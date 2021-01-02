function loadRepos() {
	const username = document.querySelector('#username').value;
	const url = `https://api.github.com/users/${username}/repos`;
	const ul = document.querySelector('ul');
	console.log(url)
	fetch(url)
		.then(res => res.json())
		.then(data => {
			ul.innerHTML = data.map(el => `<li><a href="${el["html_url"]}">${el["full_name"]}</a></li>`).join('')
		});
}