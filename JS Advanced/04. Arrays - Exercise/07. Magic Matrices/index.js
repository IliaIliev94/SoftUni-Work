function magicMatrices(data) {
    let isEqual = true;
    let sum = 0;
    for(let i = 0; i < data.length; i++) {
        sum += data[0][i];
    }
    for(let i = 1; i < data.length; i++) {
        let test = 0;
        for(let j = 0; j < data.length; j++) {
            test += data[i][j];
        }
        if(test != sum) {
            isEqual = false;
        }
    }
    for(let i = 0; i < data.length; i++) {
        let test = 0;
        for(let j = 0; j < data.length; j++) {
            test += data[j][i];
        }
        if(test != sum) {
            isEqual = false;
        }
    }
    console.log(isEqual);
}

magicMatrices([[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]);