function populationInTowns(data) {
    let towns = {

    };
    for(let i = 0; i < data.length; i++) {
        let townData = data[i].split(" <-> ");
        let town = townData[0];
        let population = Number(townData[1]);
        let keys = Object.keys(towns);
        if(keys.includes(town)) {
            towns[town] += population;
        }
        else {
            towns[town] = population;
        }

    }
    for(let town in towns) {
        console.log(`${town} : ${towns[town]}`);
    }
}

populationInTowns(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']);