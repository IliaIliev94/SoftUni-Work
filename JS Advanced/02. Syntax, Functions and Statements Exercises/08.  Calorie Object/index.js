function calorieObject(data) {
    let products = new Object();
    for(let i = 0; i < data.length; i+= 2) {
        products[data[i]] = Number(data[i + 1]);
    }
    console.log(products);
}
calorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);