function roadRadar(data) {
    let speed = data[0];
    const area = data[1];
    let speedLimit = 0;
    switch (area) {
        case "motorway":
            speedLimit = 130;
            break;
        case "interstate":
            speedLimit = 90;
            break;
        case "city":
            speedLimit = 50;
            break;
        default:
            speedLimit = 20;
    }
    const speedDifference = speed - speedLimit
    if(speedDifference > 0 && speedDifference <= 20) {
        console.log("speeding");
    }
    else if(speedDifference > 20 && speedDifference <= 40) {
        console.log("excessive speeding");
    }
    else if(speedDifference > 40) {
        console.log("reckless driving");
    }
}

roadRadar([200, 'motorway'])