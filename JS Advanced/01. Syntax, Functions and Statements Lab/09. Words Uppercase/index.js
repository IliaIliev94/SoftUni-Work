function lettersToUpper(input) {
    let result = [];
    const regex = /\w+/g;
    let match = regex.exec(input);
    while(match) {
        result.push(match[0].toUpperCase());
        match = regex.exec(input);
    }
    console.log(result.join(", "));
}

lettersToUpper("Hi, how are you!");