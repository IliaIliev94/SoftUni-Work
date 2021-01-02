function lowestPrices(data) {
    data = data.map(row => row.split(' | ').filter(row => row != ''));
    let products = {

    };
    for(let product of data) {
        let productExists = Object.keys(products);
        if(productExists.includes(product[1])) {
            let index = 0;
            if(containsCity(products[product[1]], product[0])) {
                products[product[1]][findIndex(products[product[1]], product[0])][product[0]] = Number(product[2]);
            }
            else {
                let city = {

                }
                city[product[0]] = Number(product[2])
                products[product[1]].push(city)
            }
        }
        else {
            let city = {
            }
            city[product[0]] = Number(product[2]);
            products[product[1]] = new Array();
            products[product[1]].push(city)
        }
    function containsCity(object, city) {
                for(let i = 0; i < object.length; i++) {
                    let cities = Object.keys(object[i]);
                    for(let key of cities) {
                        if(key === city) {
                            return true;
                        }
                    }
                }
                return false;
    }
        function findIndex(object, city) {
            for(let i = 0; i < object.length; i++) {
                let cities = Object.keys(object[i]);
                for(let key of cities) {
                    if(key === city) {
                        return i;
                    }
                }
            }
            return -1;
        }


    }
    for(let product of Object.keys(products)) {
        let min = Number.MAX_SAFE_INTEGER;
        let minCity = "";
        for(let i = 0; i < products[product].length; i++) {
            let keys = Object.keys(products[product][i]);
            for(let city of keys) {
                if(products[product][i][city] < min) {
                    min = products[product][i][city];
                    minCity = city;
                }
            }
        }
        console.log(`${product} -> ${min} (${minCity})`);
    }
}

lowestPrices(['Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999',
    'New York City | Mitsubishi | 10000',
    'New York City | Mitsubishi | 1000',
    'Mexico City | Audi | 100000',
    'Washington City | Mercedes | 1000]']);