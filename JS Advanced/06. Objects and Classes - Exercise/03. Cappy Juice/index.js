function cappyJuice(data) {
    let parsedData = data.map(element => element.split(" => "));
    let juices = {};
    let bottles = {};
    parsedData.forEach(juice => {
        let keys = Object.keys(juices);
        if(keys.includes(juice[0])) {
            juices[juice[0]] += Number(juice[1]) / 1000;
        }
        else {
            juices[juice[0]] = Number(juice[1]) / 1000;
        }

        if(juices[juice[0]] >= 1) {
            bottles[juice[0]] = juices[juice[0]];
        }
    });
    for(let key of Object.keys(bottles)) {
        if(bottles[key] >= 1) {
            console.log(`${key} => ${Math.floor(bottles[key])}`);
        }
    }
}

cappyJuice(['Kiwi => 234',
'Pear => 2345',
'Watermelon => 3456',
'Kiwi => 4567',
'Pear => 5678',
'Watermelon => 6789'])