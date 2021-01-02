function solve() {
    let result = [];
    let resultNums = {

    }
    arguments.forEach(element =>{
        result.push(`${typeof(element)}: ${element}`);
        if(!resultNums[typeof(element)]) {
            resultNums[typeof(element)] = 0;
        }
        resultNums[typeof(element)]++;
    });
    let sort = Object.keys(resultNums).sort((a, b) => resultNums[b] - resultNums[a]);
    sort.forEach(element => result.push(`${element} = ${resultNums[element]}`));
    console.log(result.join('\n'));
}

solve('Cat', 42, function() {console.log()}, 43);