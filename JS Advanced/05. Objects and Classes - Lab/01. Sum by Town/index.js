function sumByTown(data) {
    let townData = {
    };
    for(let i = 0; i < data.length - 1; i+= 2) {
        let towns = Object.keys(townData);
        let town = data[i];
        let value = data[i + 1];
        if(towns.includes(town)) {
            townData[town] += Number(value);
        }
        else {
            townData[town] = Number(value);
        }

    }
    console.log(JSON.stringify((townData)));
}

sumByTown(['Sofia','20','Varna','3','sofia','5','varna','4'])