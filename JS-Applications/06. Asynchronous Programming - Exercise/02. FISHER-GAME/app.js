const baseUrl = `https://fisher-game.firebaseio.com/catches`;
function attachEvents() {
    console.log('TODO...');
    const loadBtn = document.querySelectorAll('.load')[0];
    const addBtn = document.querySelectorAll('.add')[0];
    const catches = document.querySelector('#catches');
    //Add an event listener to the load button
    //When the load button is pressed a get request should be made to https://fisher-game.firebaseio.com/catches.json
    loadBtn.addEventListener('click', function () {
        fetch(`${baseUrl}.json`)
            .then(res => res.json())
            .then(data => {
                catches.innerHTML = '';
                //After that for each of the results create a div with class catch containing the object info
                Object.keys(data).forEach(fishCatch => {
                    const catchDiv = createCatchDiv(data, fishCatch)
                    catches.appendChild(catchDiv);
                });
            });
    });
    addBtn.addEventListener('click', function () {
        const angler = document.querySelector('#addForm > .angler').value;
        const weight = document.querySelector('#addForm > .weight').value;
        const species = document.querySelector('#addForm > .species').value;
        const location = document.querySelector('#addForm > .location').value;
        const bait = document.querySelector('#addForm > .bait').value;
        const captureTime = document.querySelector('#addForm > .captureTime').value;
        fetch(`${baseUrl}.json`, {
            method: 'POST',
            body: JSON.stringify({
                "angler": angler,
                "weight": weight,
                "species": species,
                "location": location,
                "bait": bait,
                "captureTime": captureTime
            })
        })
            .then(() => clearInputFields())
            .catch(err => console.log(err));
    });
    function createCatchDiv(data, fishCatch) {
        const catchDiv = createElement('div', 'catch', '');
        catchDiv.setAttribute('data-id', fishCatch);
        createCatchDivComponents(data, fishCatch).forEach(el => catchDiv.appendChild(el));
        return catchDiv;
    }

    function createCatchDivComponents(data, fishCatch) {
        const anglerLabel = createElement('label','', 'Angler');
        const anglerInput = createElement('input', 'angler', '',
            {type: "text", value: data[fishCatch]["angler"]});
        const horizontal = document.createElement('hr');
        const weightLabel = createElement('label', '', 'Weight');
        const weightInput = createElement('input', 'weight', '',
            {type: "number", value: data[fishCatch]["weight"]});
        const speciesLabel = createElement('label', '', 'Species');
        const speciesInput = createElement('input', 'species', '',
            {type: "text", value: data[fishCatch]["species"]});
        const locationLabel = createElement('label', '', 'Location');
        const locationInput = createElement('input', 'location', '',
            {type: "text", value: data[fishCatch]["location"]});
        const baitLabel = createElement('label', '', 'Bait');
        const baitInput = createElement('input', 'bait', '',
            {type: "text", value: data[fishCatch]["bait"]});
        const captureTimeLabel = createElement('label', '', 'Capture Time');
        const captureTomeInput = createElement('input', 'captureTime', '',
            {type: "number", value: data[fishCatch]["captureTime"]});
        const updateBtn = createElement('button', 'update', 'Update');
        const deleteBtn = createElement('button', 'delete', 'Delete');
        updateBtn.addEventListener('click', function () {
            updateInfo(fishCatch, anglerInput.value, weightInput.value, speciesInput.value, locationInput.value, baitInput.value, captureTomeInput.value);
        });
        deleteBtn.addEventListener('click', function (e) {
            deleteCatch(fishCatch, e.target.parentElement);
        });
        let components = [anglerLabel, anglerInput, horizontal, weightLabel, weightInput, horizontal
            , speciesLabel, speciesInput, horizontal, locationLabel, locationInput, horizontal,
            baitLabel, baitInput, horizontal, captureTimeLabel, captureTomeInput, horizontal, updateBtn, deleteBtn];
        return components;
    }

    function updateInfo(id, angler, weight, species, location, bait, captureTime) {
        fetch(`${baseUrl}/${id}.json`, {
            method: 'PUT',
            body: JSON.stringify({
                "angler": angler,
                "weight": weight,
                "species": species,
                "location": location,
                "bait": bait,
                "captureTime": captureTime
            })
        })
            .catch(err => console.log(err));
    }

    function deleteCatch(id, entity) {
        fetch(`${baseUrl}/${id}.json`, {
            method: 'DELETE'
        })
            .then(() => entity.remove());
    }

    function createElement(element, className, text, attributes) {
        let result = document.createElement(element);
        if(className !== '') {
            result.classList.add(className);
        }
        result.textContent = text;
        if(attributes !== undefined) {
            Object.keys(attributes).forEach(attribute => {
                result.setAttribute(attribute, attributes[attribute]);
            });
        }
        return result;
    }

    function clearInputFields() {
        document.querySelector('#addForm > .angler').value = '';
        document.querySelector('#addForm > .weight').value = '';
        document.querySelector('#addForm > .species').value = '';
        document.querySelector('#addForm > .location').value = '';
        document.querySelector('#addForm > .bait').value = '';
        document.querySelector('#addForm > .captureTime').value = '';
    }
}

attachEvents();

