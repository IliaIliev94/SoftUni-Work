function equalNeighbors(data) {
    let pairsCount = 0;
    for(let i = 0; i < data.length; i++) {
        for(let j = 0; j < data[i].length; j++) {
            if(j + 1 < data[i].length && data[i][j + 1] === data[i][j]) {
                pairsCount++;
            }
            if(i + 1 < data.length && data[i + 1][j] === data[i][j]) {
                pairsCount++;
            }
        }
    }
    console.log(pairsCount);
}

equalNeighbors([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']]);