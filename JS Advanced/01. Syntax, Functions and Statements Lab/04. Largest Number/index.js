function largestNumber(one, two, three) {
    let maxNumber;
    if(one >= two && one >= three) {
        maxNumber = one;
    }
    else if(two >= one && two >= three) {
        maxNumber = two;
    }
    else {
        maxNumber = three;
    }
    console.log("The largest number is " + maxNumber + ".");
}

largestNumber(1, 4, 3)