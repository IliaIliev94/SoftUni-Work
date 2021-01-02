function solution(input) {
    let parsedData = JSON.parse(input);
    return parsedData.reduce((acc, curr) => {
        Object.entries(curr).forEach(([key, value]) => {
            if(!acc[key]) {
                acc[key] = value;
            }
        })
        return acc;
    }, {})
}

console.log(solution(`[{"canFly": true},{"canMove":true, "doors": 4},{"capacity": 255},{"canFly":true, "canLand": true}]`))