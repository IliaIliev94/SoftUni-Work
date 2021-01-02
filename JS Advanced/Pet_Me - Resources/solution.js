function solve() {
    // TODO ...
    let inputs = document.getElementsByTagName('input');
    let addBtn = document.querySelectorAll('button')[0];
    console.log(addBtn)
    addBtn.addEventListener('click', function (event) {
        event.preventDefault();
        let isCorrect = true;
        Array.from(inputs).forEach(element => {
            console.log(element);
            if(element.value === '') {
                isCorrect = false;
            }
        });
        if((isCorrect) && (!isNaN(Number(inputs[1].value)))) {
            let list = document.createElement('li');
            let p = document.createElement('p');
            p.innerHTML = `<strong>${inputs[0].value}</strong> is a <strong>${Number(inputs[1].value)}</strong> year old <strong>${inputs[2].value}</strong>`;
            let span = document.createElement('span');
            span.textContent = `Owner: ${inputs[3].value}`;
            let button = document.createElement('button');
            button.textContent = 'Contact with owner';
            list.appendChild(p);
            list.appendChild(span);
            button.addEventListener('click', function test() {
                let div = document.createElement('div');
                button.parentElement.appendChild(div);
                button.remove();
                let newBtn = document.createElement('button');
                let input = document.createElement('input');
                input.placeholder = 'Enter your names';
                newBtn.textContent = 'Yes! I take it!'
                div.appendChild(input);
                div.appendChild(newBtn);
                newBtn.addEventListener('click', function test1() {
                    if(newBtn.previousElementSibling.value !== '') {
                        document.querySelector('#adopted > ul').appendChild(newBtn.parentElement.parentElement);
                        span.textContent = `New Owner: ${newBtn.previousElementSibling.value}`;
                        div.remove();
                        let lastBtn = document.createElement('button');
                        lastBtn.textContent = 'Checked'
                        list.appendChild(lastBtn);
                        lastBtn.addEventListener('click', function () {lastBtn.parentElement.remove()})
                    }
                });


            });
            list.appendChild(button);
            document.querySelector('#adoption > ul').appendChild(list);
            Array.from(inputs).forEach(element => element.value = '');
        }
    })
}

