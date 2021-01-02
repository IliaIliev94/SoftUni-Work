function solve(nums, keyWord) {
    let sort = {
        asc: () => nums.sort((a, b) => a - b),
        desc: () => nums.sort((a, b) => b - a)
    }
    return sort[keyWord]();
}

console.log(solve([14, 7, 17, 6, 8], 'desc'));