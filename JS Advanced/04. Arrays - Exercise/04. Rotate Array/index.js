function rotateArray(data) {
    let rotationAmount = Math.min(data.pop(), data.length);
    for(let i = 0; i < rotationAmount; i++) {
        let temp = data[data.length - 1];
        for(let j =  data.length - 1; j >= 1; j--) {
            data[j] = data[j - 1];
        }
        data[0] = temp;
    }
    console.log(data.join(' '));
}

rotateArray(['1',
'2',
'3',
'4',
'2'])