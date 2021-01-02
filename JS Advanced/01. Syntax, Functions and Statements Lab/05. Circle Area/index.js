function area(arg) {
    if(typeof arg == 'number') {
        let area = (Math.PI * Math.pow(arg, 2)).toFixed(2);
        console.log(area);
    }
    else {
        console.log(`We can not calculate the circle area, because we receive a ${typeof arg}.`);
    }
}

area('name');