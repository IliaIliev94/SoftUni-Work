$(() => {
    // TODO
    console.log('yes');
    let monkeysList = document.querySelector('.monkeys');
    const template = Handlebars.compile(document.querySelector('#monkey-template').textContent);
    monkeysList.innerHTML = monkeys.map(monkey => template(monkey)).join('');

    let infoBtns = document.querySelectorAll('button');
    console.log(infoBtns);
    infoBtns.forEach(button => button.addEventListener('click', toggleStatus));

    function toggleStatus(e) {
        let paragraph = e.target.nextElementSibling;
        if(paragraph.style.display !== 'block') {
            paragraph.style.display = 'block';
        }
        else {
            paragraph.style.display = 'none';
        }
    }
})