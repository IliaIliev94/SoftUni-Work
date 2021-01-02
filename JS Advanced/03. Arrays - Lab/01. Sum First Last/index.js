function sumFirstLast(data) {
    const first = Number(data[0]);
    const last = Number(data[data.length - 1]);
    const result = first + last;
    console.log(result);
}

sumFirstLast(['5', '10']);