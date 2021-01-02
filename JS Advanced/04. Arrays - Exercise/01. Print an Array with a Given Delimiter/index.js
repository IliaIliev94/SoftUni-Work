function printDelimeter(data) {
    let result = new String();
    let delimiter = data[data.length - 1];
    for(let i = 0; i < data.length - 2; i++) {
        result += data[i] + delimiter;
    }
    result += data[data.length - 2];
    console.log(result);
}

printDelimeter(['How about no?',
'I',
'will',
'not',
'do',
'it!',
'_'])