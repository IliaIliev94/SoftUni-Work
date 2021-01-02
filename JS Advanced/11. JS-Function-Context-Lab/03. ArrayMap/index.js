function arrayMap(nums, func) {
    const myNums = nums.reduce((total, value) => {
        total.push(func(value));
        return total
    }, []);
    return myNums;
}

let nums = [1, 2, 3, 4, 5];
console.log(arrayMap(nums, (item) => item * 2));