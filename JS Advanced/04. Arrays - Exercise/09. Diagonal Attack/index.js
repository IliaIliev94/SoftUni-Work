function diagonalAttack(data) {
    let matrix = createMatrix(data);
    let primaryDiagonalSum = getPrimaryDiagonalSum(matrix);
    let secondaryDiagonalSum = getSecondaryDiagonalSum(matrix);

    if(primaryDiagonalSum === secondaryDiagonalSum) {
        setNumbersToDiagonalSum(matrix, primaryDiagonalSum);
    }
    for(let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(' '));
    }
}

function createMatrix(data) {
    let matrix = new Array();
    for(let i = 0; i < data.length; i++) {
        let tempArray = [];
        let numbers = data[i].split(' ');
        for(let j = 0; j < numbers.length; j++) {
            tempArray.push(Number(numbers[j]));
        }
        matrix.push(tempArray);
    }
    return matrix;
}

function getPrimaryDiagonalSum(matrix) {
    let primaryDiagonalSum = 0;
    for(let i = 0; i < matrix.length; i++) {
        primaryDiagonalSum += matrix[i][i];
    }
    return primaryDiagonalSum;
}

function getSecondaryDiagonalSum(matrix) {
    let secondaryDiagonalSum = 0;
    for(let i = matrix.length - 1, counter = 0; i >= 0; i--, counter++) {
        secondaryDiagonalSum += matrix[counter][i];
    }
    return secondaryDiagonalSum;
}

function setNumbersToDiagonalSum(matrix, primaryDiagonalSum) {
    for(let i = 0, primaryDiagonalCounter = 0, secondaryDiagonalCounter = matrix.length - 1;
        i < matrix.length; i++, primaryDiagonalCounter++, secondaryDiagonalCounter--) {
        for(let j = 0; j < matrix[i].length; j++) {
            if(j !== primaryDiagonalCounter && j !== secondaryDiagonalCounter) {
                matrix[i][j] = primaryDiagonalSum;
            }
        }
    }
}

diagonalAttack(['5 3 12 3 1',
'11 4 23 2 5',
'101 12 3 21 10',
'1 4 5 2 2',
'5 22 33 11 1'])