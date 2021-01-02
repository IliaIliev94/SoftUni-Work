function townsToJson(data) {
    let towns = new Array();
    let properties = data[0].split(/\| | \| | \|/).filter(item => item);
    for(let i = 1; i < data.length; i++) {
        let cityData = data[i].split(/\| | \| | \|/).filter(item => item);
        let entry = {
            "Town" : cityData[0],
            "Latitude": Number(parseFloat(cityData[1]).toFixed(2)),
            "Longitude": Number(parseFloat(cityData[2]).toFixed(2))
        };
        towns.push(entry);
    }
    console.log(JSON.stringify(towns));
}

townsToJson(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']);