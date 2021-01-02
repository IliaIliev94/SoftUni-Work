function smallestTwoNumbers(data) {
    let smallestNumbers = new Array();
    let newArray = new Array();
    for(let i = 0; i < data.length; i++) {
        newArray[i] = data[i];
    }
    for(let i = 0; i < Math.min(2, newArray.length); i++) {
        let min = Number.MAX_VALUE;
        let position;
        for(let j = 0; j < newArray.length; j++) {
            if(newArray[j] <= min) {
                min = newArray[j];
                position = j;
            }
        }
        smallestNumbers[i] = min;
        newArray.splice(position, 1);
    }

    console.log(smallestNumbers.join(" "));
}

smallestTwoNumbers([3, 0, 10, 4, 7, 3])