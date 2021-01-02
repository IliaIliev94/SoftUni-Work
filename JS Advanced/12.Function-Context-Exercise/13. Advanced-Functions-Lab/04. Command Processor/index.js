function solution() {
    let str = '';
    return  {
        append: (s) => str += s,
        removeStart: (n) => str = str.substr(n, str.length - n),
        removeEnd: (n) => str = str.substr(0, str.length - n),
        print: () => console.log(str)
    }
}

let mySol = solution();
mySol.append('Ilia');
mySol.append('Miroslavov');
mySol.removeStart(2);
mySol.print();