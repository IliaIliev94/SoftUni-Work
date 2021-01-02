function diagonalSums(data) {
    let firstDiagonalSum = (arr) => {
        let totalSum = 0;
        let counter = 0;
        for(let i = 0; i < data.length; i++) {
            totalSum += arr[i][counter];
            counter++;
        }
        return totalSum;
    }
    let secondDiagonalSum = (arr) => {
        let totalSum = 0;
        let counter = data[0].length - 1;
        for(let i = 0; i < arr.length; i++) {
            totalSum += data[i][counter];
            counter--;
        }
        return totalSum;
    }
    console.log(`${firstDiagonalSum(data)} ${secondDiagonalSum(data)}`);
}

diagonalSums([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]);