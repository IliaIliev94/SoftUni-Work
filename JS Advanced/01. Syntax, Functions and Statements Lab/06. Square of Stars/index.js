function squareOfStars(size = 5) {
    for(let i = 0; i < size; i++) {
        let row = "";
        for(let j = 0; j < size; j++) {
            row += '*' + ' ';
        }
        row = row.trimEnd();
        console.log(`${row}`);
    }
}

squareOfStars(3);