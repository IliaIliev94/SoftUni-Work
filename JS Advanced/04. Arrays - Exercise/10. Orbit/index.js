function orbit(data) {
    let counter = 1;
    let totalNumbers = 1;
    let matrix = initializeMatrix(data,counter);
    counter++;

    let oldCoordinates = [data[2], data[3]];

    while(totalNumbers < matrix.length * matrix.length) {
        let newCoordinates = [];
        for(let i = 0; i < oldCoordinates.length; i+= 2) {
            for(let j = oldCoordinates[i] - 1; j <= oldCoordinates[i] + 1; j++) {
                for(let k = oldCoordinates[i + 1] - 1; k <= oldCoordinates[i + 1] + 1; k++) {
                    if((j >= 0 && j < matrix.length) && (k >= 0 && k < matrix.length) && matrix[j][k] === undefined) {
                        newCoordinates.push(j, k);
                        matrix[j][k] = counter;
                        totalNumbers++;
                    }
                }
            }
        }
        oldCoordinates = newCoordinates;
        counter++;
    }
    for(let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(' '));
    };
}

function initializeMatrix(data, counter) {
    let matrix = new Array();
    for(let i = 0; i < data[0]; i++) {
        matrix.push(new Array(data[1]));
    }
    matrix[data[2]][data[3]] = counter;
    return matrix;
}

orbit([3, 3, 2, 2]);