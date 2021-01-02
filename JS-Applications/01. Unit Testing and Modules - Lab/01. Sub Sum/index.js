function subSum(arr, startIndex, endIndex) {
    //Check if the first element is not an array
    if(!Array.isArray(arr)) {
        return NaN;
    }
    //If the start index is less than zero then change it to zero
    if(startIndex < 0) {
        startIndex = 0;
    }
    //If the lastIndex is more than the length of the array then change it to the last element
    if(endIndex > arr.length - 1) {
        endIndex = arr.length - 1;
    }
    let sum = 0;
    for(let i = startIndex; i <= endIndex; i++) {
        sum += Number(arr[i]);
    }
    return sum;
}

console.log(subSum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1));