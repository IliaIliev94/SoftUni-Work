function nthElementPrint(data) {
    let iterationRange = Number(data[data.length - 1]);
    for(let i = 0; i < data.length - 1; i+= iterationRange) {
        console.log(data[i]);
    }
}

nthElementPrint(['1',
'2',
'3',
'4',
'5',
'6'])