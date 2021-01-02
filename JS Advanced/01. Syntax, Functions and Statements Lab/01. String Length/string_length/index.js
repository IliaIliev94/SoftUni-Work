function sumLength(first, second, third) {
    return first.length + second.length + third.length;
}

function stringLength(first, second, third) {
    let sumLengthResult = sumLength(first, second, third);
    let averageLength = Math.floor(sumLengthResult / 3);
    console.log(sumLengthResult);
    console.log(averageLength);
}

stringLength('chocolate', 'ice cream', 'cake');