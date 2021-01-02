function buyFruit(fruit, grams, price) {
    let totalPrice = grams / 1000 * price;
    console.log(`I need $${totalPrice.toFixed(2)} to buy ${(grams/1000).toFixed(2)} kilograms ${fruit}.`)
}

buyFruit("apple", 1563, 2.35);