function solution(commands) {
    let string = [];
    let functions = {
        add: (word) =>  string.push(word),
        remove: (word) => {
            while(string.includes(word)) {
                string.splice(string.indexOf(word), 1);
            }
        },
        print: () => console.log(string.join(','))
    }
    commands.forEach(element => {
        let data = element.split(' ');
        if(data.length > 1) {
            return functions[data[0]](data[1]);
        }
        else {
            return functions[data[0]]();
        }
    })
}

solution([`add pesho`, `add george`, `add peter`, `remove peter`,`print`])