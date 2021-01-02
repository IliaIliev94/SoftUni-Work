function validityChecker(data) {
    const x1 = data[0];
    const y1 = data[1];
    const x2 = data[2];
    const y2 = data[3];
    const diff1 = Math.sqrt(Math.pow(0 - x1, 2) + Math.pow((0 - y1), 2));
    const diff2 = Math.sqrt(Math.pow((0 - x2), 2) + Math.pow((0 - y2), 2));
    const diff3 = Math.sqrt(Math.pow((x1 - x2), 2) + Math.pow((y1 - y2), 2));
    if(diff1 === Math.floor(diff1)) {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }
    else {
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }
    if(diff2 === Math.floor(diff2)) {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }
    else {
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }
    if(diff3 === Math.floor(diff3)) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }
    else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}

validityChecker([2, 1, 1, 1]);