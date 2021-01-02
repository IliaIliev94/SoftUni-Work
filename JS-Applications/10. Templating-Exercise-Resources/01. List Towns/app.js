const loadBtn = document.querySelector('#btnLoadTowns');
const ul = document.querySelector('#root > ul');

const htmlTemplate = `<li>{{name}}</li>`
const template = Handlebars.compile(htmlTemplate);

loadBtn.addEventListener('click', function(e) {
    e.preventDefault()
    const towns =  [];
    document.querySelector('#towns').value.split(', ').forEach(el => {
        towns.push({"name": el})
    });
    ul.innerHTML = towns.map(town => template(town)).join('');
});