function lastKNumbersSequence(first, second) {
    let sequenceArray = [1];
    for(let i = 1; i < first; i++) {
        sequenceArray[i] = calculateIndexValue(i, sequenceArray, second);
    }
    console.log(sequenceArray.join(" "));
}

function calculateIndexValue(index, arr, boundary) {
    let sum = 0;
    if(index < boundary) {
        for(let j = 0; j < index; j++) {
            sum += arr[j];
        }
    }
    else {
        for(let j = index - boundary; j < index; j++) {
            sum += arr[j];
        }
    }
    return sum;
}

lastKNumbersSequence(6, 3);