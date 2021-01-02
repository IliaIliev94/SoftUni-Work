function storeCatalog(data) {
    data.sort();
    let parsedData = data.map(element => element.split(" : "));
    let catalogue = {};
    parsedData.forEach(element => {
        let catalogueKeys = Object.keys(catalogue);
        if(catalogueKeys.includes(element[0][0])) {
            catalogue[element[0][0]].push({[element[0]]: element[1]});
        }
        else {
            catalogue[element[0][0]] = new Array();
            catalogue[element[0][0]].push({[element[0]]: element[1]});
        }
    });
    for(let product of Object.keys(catalogue)) {
        console.log(product[0]);
        for(let i = 0; i < catalogue[product].length; i++) {
            for(let x of Object.keys(catalogue[product][i])) {
                console.log(` ${x}: ${catalogue[product][i][x]}`)
            }

        }

    }

}

storeCatalog(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10'])