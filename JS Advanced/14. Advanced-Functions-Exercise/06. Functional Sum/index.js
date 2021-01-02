function add(nums) {
    //Initialize the sum variable to zero
    let sum = nums;
    let myFunc = (num) => {
        sum += num;
        return myFunc;
    }
    myFunc.toString = () => sum;
    return myFunc;
}

console.log(Number(add(1)(2)));