function extractIncreasingSubsequences(data) {
    let increasingSubsequences = [data[0]];
    for(let i = 1; i < data.length; i++) {
        if(data[i] >= increasingSubsequences[increasingSubsequences.length - 1]) {
            increasingSubsequences.push(data[i]);
        }
    }
    for(let i = 0; i < increasingSubsequences.length; i++) {
        console.log(increasingSubsequences[i]);
    }
}

extractIncreasingSubsequences([20,
    3,
    2,
    15,
    6,
    1]);