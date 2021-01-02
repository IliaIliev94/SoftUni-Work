function createArticle() {
    //TODO...
	let title = document.getElementById("createTitle").value;
	let content = document.getElementById("createContent").value;
	let article = document.createElement("article");
	if(title !== "" && content !== "") {
        article.appendChild(CreateArticleTitle(title));
        article.appendChild(CreateArticleText(content));
        document.getElementById("articles").appendChild(article);
        cleanFields();
    }

    function CreateArticleTitle(title) {
        let articleTitle = document.createElement("h3");
        articleTitle.textContent = title;
        return articleTitle;
    }

    function CreateArticleText(text) {
        let articleText = document.createElement("p");
        articleText.textContent = text;
        return articleText;
    }

    function cleanFields() {
        document.getElementById("createTitle").value = "";
        document.getElementById("createContent").value = "";
    }


}

