function negativePositiveNumbers(data) {
    let filteredArray = new Array();
    for(let i = 0; i < data.length; i++) {
        if(data[i] < 0) {
            filteredArray.unshift(data[i]);
        }
        else {
            filteredArray.push(data[i]);
        }
    }
    for(let i = 0; i < filteredArray.length; i++) {
        console.log(filteredArray[i]);
    }
}

negativePositiveNumbers([3, -2, 0, -1]);