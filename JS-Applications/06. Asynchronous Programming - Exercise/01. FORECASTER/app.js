const baseUrl = `https://judgetests.firebaseio.com/locations.json`;
const forecastUrl = `https://judgetests.firebaseio.com/forecast`;
const weatherSymbols = {
    "Sunny": "&#x2600", // ☀
    "Partly sunny": "&#x26C5;", // ⛅
    "Overcast": "&#x2601;", // ☁
    "Rain": "&#x2614;", // ☂
    "Degrees": "°", // °
}
function attachEvents() {
    const submitBtn = document.querySelector('#submit');
    const forecast = document.querySelector('#forecast');
    //When the user clicks the Get Weather button send a get request to the locations API
    submitBtn.addEventListener('click', function () {
        const city = document.querySelector('#location').value;
        const current = document.querySelector('#current');
        const upcoming = document.querySelector('#upcoming');
        clearInputField();
        deletePreviousForecast();
        let code = '';
        fetch(baseUrl)
            .then(res =>res.json())
            .then(data => {
                code = getCode(data, city);
                let currentRequest = fetch(`${forecastUrl}/today/${code}.json`)
            //After that using the code from the data received make two more get requests
            .then(res => res.json())
            let upcomingRequest = fetch(`${forecastUrl}/upcoming/${code}.json`)
                .then(res => res.json())
                Promise.all([currentRequest, upcomingRequest])
            .then(([currentData, upcomingData]) => {
                current.firstElementChild.textContent = 'Current conditions';
                upcoming.firstElementChild.textContent = 'Three-day forecast';
                forecast.style.display = 'initial';
                const currentForecast = createCurrentForecast(currentData);
                const divForecastInfo = document.createElement('div');
                divForecastInfo.classList.add('forecast-info');
                upcomingData["forecast"].forEach(forecast => {
                    createUpcomingForecast(divForecastInfo, forecast);
                });
                current.appendChild(currentForecast);
                upcoming.appendChild(divForecastInfo);
            })
            .catch(err =>  {
                current.firstElementChild.textContent = 'Error';
                upcoming.firstElementChild.textContent = 'Error';
            });

        //One for the current weather forecast of the city code
        //And another one for the weather forecast for three days ahead
    });

    function getCode(data, city) {
        let code = '';
        data.forEach(element => {
            if(element.name === city) {
                code = element.code;
            }
        });
        return code;
    }

    function createCurrentForecast(data) {
        const forecastsDiv = document.createElement('div');
        forecastsDiv.classList.add('forecasts');
        const conditionSpan = document.createElement('span');
        conditionSpan.classList.add('condition');
        conditionSpan.classList.add('symbol');
        conditionSpan.innerHTML = weatherSymbols[data["forecast"]["condition"]];
        const secondSpan = document.createElement('span');
        secondSpan.classList.add('condition');
        const citySpan = document.createElement('span');
        citySpan.classList.add('forecast-data');
        citySpan.textContent = data["name"];
        const degreesSpan = document.createElement('span');
        degreesSpan.classList.add('forecast-data');
        degreesSpan.innerHTML = `${data["forecast"]["low"]}${weatherSymbols["Degrees"]}/${data["forecast"]["high"]}${weatherSymbols["Degrees"]}`;
        const typeSpan = document.createElement('span');
        typeSpan.classList.add('forecast-data');
        typeSpan.innerHTML = data["forecast"]["condition"];
        secondSpan.appendChild(citySpan);
        secondSpan.appendChild(degreesSpan);
        secondSpan.appendChild(typeSpan);
        forecastsDiv.appendChild(conditionSpan);
        forecastsDiv.appendChild(secondSpan);
        return forecastsDiv;
    }

    function createUpcomingForecast(divForecastInfo, forecast) {
        const upcomingSpan = document.createElement('span');
        upcomingSpan.classList.add('upcoming');
        const symbolSpan = document.createElement('span');
        symbolSpan.classList.add('symbol');
        symbolSpan.innerHTML = weatherSymbols[forecast["condition"]];
        const degreesSpan = document.createElement('span');
        degreesSpan.classList.add('forecast-data');
        degreesSpan.innerHTML = `${forecast["low"]}${weatherSymbols["Degrees"]}/${forecast["high"]}${weatherSymbols["Degrees"]}`;
        const weatherTypeSpan = document.createElement('span');
        weatherTypeSpan.classList.add('forecast-data');
        weatherTypeSpan.innerHTML = forecast["condition"];
        upcomingSpan.appendChild(symbolSpan);
        upcomingSpan.appendChild(degreesSpan);
        upcomingSpan.appendChild(weatherTypeSpan);
        divForecastInfo.appendChild(upcomingSpan);
    }

    function deletePreviousForecast() {
        let current = document.querySelector('#current');
        for(let i = 1; i < current.children.length; i++) {
            current.children[i].remove();
        }
        let upcoming = document.querySelector('#upcoming');
        for(let i = 1; i < upcoming.children.length; i++) {
            upcoming.children[i].remove();
        }
    }

    function clearInputField() {
        document.querySelector('#location').value = '';
    }
})
}

attachEvents();