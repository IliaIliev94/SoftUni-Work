function sortByTwoCriteria(data) {
    for(let i = 0; i < data.length - 1; i++) {
        let temp = data[i];
        let position = i;
        for(let j = i + 1; j < data.length; j++) {
            if(data[j].length < temp.length) {
                temp = data[j];
                position = j;
            }
            else if(data[j].length === temp.length && data[j] < temp) {
                temp = data[j];
                position = j;
            }
        }
        for(let j = position; j > i; j--) {
            data[j] = data[j - 1];
        }
        data[i] = temp;
    }
    for(let i = 0; i < data.length; i++) {
        console.log(data[i]);
    }
}

sortByTwoCriteria(['test',
'Deny',
'omen',
'Default'])