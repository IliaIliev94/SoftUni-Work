function sameNumbers(number) {
    number = number.toString();
    let areSame = true;
    let sum = 0;

    for(let i = 0; i < number.length; i++) {
        if(number[i] != number[0]) {
            areSame = false;
        }
        sum += Number(number[i]);
    }
    console.log(areSame);
    console.log(sum);
}

sameNumbers(1234);