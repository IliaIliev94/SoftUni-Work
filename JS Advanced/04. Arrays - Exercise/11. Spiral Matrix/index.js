function spiralMatrix(first, second) {
    let matrix = new Array(first);
    for(let i = 0; i < first; i++) {
        matrix[i] = new Array(second);
    }
    let startRowCounter = 0;
    let endRowCounter = 0;
    let leftRowCounter = 0;
    let bottomRowCounter = 0;
    let counter = 1;
    while(counter <= matrix.length * matrix.length) {

        for(let j = startRowCounter; j < matrix.length - startRowCounter && counter <= matrix.length * matrix.length; j++) {
            matrix[startRowCounter][j] = counter;
            counter++;
        }
        startRowCounter++;
        for(let j = startRowCounter; j < matrix.length - bottomRowCounter && counter <= matrix.length * matrix.length; j++) {
            matrix[j][matrix.length  - startRowCounter] = counter;
            counter++;
        }
        bottomRowCounter++;
        for(let j = matrix.length - 1 -  startRowCounter; j >= endRowCounter && counter <= matrix.length * matrix.length; j--) {
            matrix[matrix.length - startRowCounter][j] = counter;
            counter++;
        }
        endRowCounter++;
        for(let j = matrix.length - 1 - startRowCounter; j >= startRowCounter && counter <= matrix.length * matrix.length; j--) {
            matrix[j][leftRowCounter] = counter;
            counter++;
        }
        leftRowCounter++;
    }
    for(let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(' '));
    }
}

spiralMatrix(3, 3);