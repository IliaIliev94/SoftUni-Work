function operations(nums) {
    let sum = () => {
        let result = 0;
        for(let i = 0; i < nums.length; i++) {
            result += nums[i];
        }
        return result;
    }
    let inverseSum = () => {
        let result = 0;
        for(let i = 0; i < nums.length; i++) {
            result += 1/nums[i];
        }
        return result;
    }
    let concatenateSum = () => {
        let result = new String();
        for(let i = 0; i < nums.length; i++) {
            result += nums[i].toString();
        }
        return result;
    }
    console.log(sum());
    console.log(inverseSum());
    console.log(concatenateSum());
}

operations([2, 4, 8, 16]);