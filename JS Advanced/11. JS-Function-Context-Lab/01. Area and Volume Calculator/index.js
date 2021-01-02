function solve(area, vol, input) {
    input = JSON.parse(input)
    let result = [];
    result = input.map(calc);
    function calc(obj) {
        let areaNum = Math.abs(area.call(obj));
        let volNum = Math.abs(vol.call(obj));
        return {area: areaNum, vol: volNum};
    }
    return result;
}

function area() {
    return this.x * this.y;
}

function vol() {
    return this.x * this.y * this.z;
}

solve(area, vol, '[ {"x":"10","y":"-22","z":"10"},\n' +
    '{"x":"47","y":"7","z":"-5"},\n' +
    '{"x":"55","y":"8","z":"0"},\n' +
    '{"x":"100","y":"100","z":"100"},\n' +
    '{"x":"55","y":"80","z":"250"} ]')