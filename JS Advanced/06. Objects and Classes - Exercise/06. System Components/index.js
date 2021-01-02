function systemComponents(data) {
    let parsedData = data.map(element => element.split(' | '));
    let components = {};
    parsedData.forEach(element => {
        let componentKeys = Object.keys(components);
        if(componentKeys.includes(element[0])) {
            let subComponentKeys = Object.keys(components[element[0]]);
            if(subComponentKeys.includes(element[1])) {
                components[element[0]][element[1]].push(element[2]);
            }
            else {
                components[element[0]][element[1]] = [element[2]];
            }
        }
        else {
            components[element[0]] = {};
            components[element[0]][element[1]] = [element[2]];
        }
    });
    for(let key of Object.keys(components)) {
        let sorted = Object.keys(components[key]).sort((a, b) => {
            return components[key][b].length - components[key][a].length;
        });
        let finalResult = {};
        for(let i = 0; i < sorted.length; i++) {
            finalResult[sorted[i]] = components[key][sorted[i]];
        }
        components[key] = finalResult;

    }
    let test = Object.keys(components).sort((a, b) => {
        let test1 = Object.values(components[a]).length;
        let test2 = Object.values(components[b]).length;
        if(test1 > test2) {
            return -1;
        }
        else if(test1 === test2 && a < b) {
            return -1;
        }
        else {
            return 1;
        }
    })
    let result = {};
    for(let i = 0; i < test.length; i++) {
        result[test[i]] = components[test[i]];
    }
    for(let x of Object.keys(result)) {
        console.log(x);
        for(let y of Object.keys(result[x])) {
            console.log(`|||${y}`);
            for(let i = 0; i < result[x][y].length; i++) {
                console.log(`||||||${result[x][y][i]}`);
            }
        }
    }
}

systemComponents(['SULS | Main Site | Home Page',
'SULS | Main Site | Login Page',
'SULS | Main Site | Register Page',
'SULS | Judge Site | Login Page',
'SULS | Judge Site | Submittion Page',
'Lambda | CoreA | A23',
'SULS | Digital Site | Login Page',
'Lambda | CoreB | B24',
'Lambda | CoreA | A24',
'Lambda | CoreA | A25',
'Lambda | CoreC | C4',
'Indice | Session | Default Storage',
'Indice | Session | Default Security',
'Lambda | CoreB | B30',
'Lambda | CoreB | B32',
'Lambda | CoreB | B33'])