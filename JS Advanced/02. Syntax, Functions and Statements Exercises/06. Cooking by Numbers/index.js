function cookingByNumbers(data) {
    let number = Number(data[0]);
    for(let i = 1; i < data.length; i++) {
        switch (data[i]) {
            case "chop":
                number /= 2;
                break;
            case "dice":
                number = Math.sqrt(number);
                break;
            case "spice":
                number++;
                break;
            case "bake":
                number *= 3;
                break;
            case "fillet":
                number = number - (number * 0.2);
                break;
        }
        console.log(number);
    }
}

cookingByNumbers(["9", "dice", "spice", "chop", "bake",
"fillet"]);