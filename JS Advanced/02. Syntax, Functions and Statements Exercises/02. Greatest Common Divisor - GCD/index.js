function greatestCommonDivisor(first, second) {
    const smallest = Math.min(first , second);
    let smallestCommonDivisor;
    for(let i = 1; i <= smallest; i++) {
        if(first % i === 0 && second % i === 0) {
            smallestCommonDivisor = i;
        }
    }
    console.log(smallestCommonDivisor);
}

greatestCommonDivisor(2154, 458);