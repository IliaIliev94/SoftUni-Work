function processOddNumbers(data) {
    let oddNumbers = new Array();
    for(let i = 0; i < data.length; i++) {
        if(i % 2 != 0) {
            oddNumbers.unshift((data[i] * 2));
        }
    }
    console.log(oddNumbers.join(" "));
}

processOddNumbers([10, 15, 20, 25]);