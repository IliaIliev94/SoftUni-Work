function autoEngineeringCompany(data) {
    let parsedData = data.map(element => element.split(" | "));
    let cars = {};
    parsedData.forEach(element => {
        let carKeys = Object.keys(cars);
        if(carKeys.includes(element[0])) {
            let modelKeys = Object.keys(cars[element[0]]);
            if(modelKeys.includes(element[1])) {
                cars[element[0]][element[1]] += Number(element[2]);
            }
            else {
                cars[element[0]][element[1]] = Number(element[2]);
            }

        }
        else {
            cars[element[0]] = {};
            cars[element[0]][element[1]] = Number(element[2]);
        }
    });
    for(let car of Object.keys(cars)) {
        console.log(car);
        for(let model of Object.keys(cars[car])) {
            console.log(`###${model} -> ${cars[car][model]}`);
        }
    }

}

autoEngineeringCompany(['Audi | Q7 | 1000',
'Audi | Q6 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10'])