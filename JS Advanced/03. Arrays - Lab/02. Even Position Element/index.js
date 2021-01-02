function evenPositionElement(data) {
    let evenPositions = new Array();
    for(let i = 0; i < data.length; i++) {
        if(i % 2 == 0) {
            evenPositions.push(data[i]);
        }
    }
    console.log(evenPositions.join(" "));
}

evenPositionElement(['5', '10']);