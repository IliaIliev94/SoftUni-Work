function getFibonator() {
    let nums = [0];
    return function() {
        if(nums.length === 1) {
            nums.push(1);
        }
        else {
            nums.push(nums[nums.length - 1] + nums[nums.length - 2]);
        }
        return nums[nums.length - 1];
    }

}

let fib = getFibonator();
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());