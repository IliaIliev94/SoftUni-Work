function sumOfNumbers(first, second) {
    let sum = 0;
    for(let i = parseFloat(first); i <= parseFloat(second); i++) {
        sum +=i;
    }
    console.log(sum);
}
sumOfNumbers('-8', '20');