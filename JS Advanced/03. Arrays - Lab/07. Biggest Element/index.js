function biggestSum(data) {
    let largest = Number.MIN_SAFE_INTEGER
    for(let i = 0; i < data.length; i++) {
        for(let j = 0; j < data[i].length; j++) {
            if(data[i][j] > largest) {
                largest = data[i][j];
            }
        }
    }
    console.log(largest);
}

biggestSum([[3, 5, 7, 12],
    [-1, 4, 33,
        2],
    [8, 3, 0, 4]]);