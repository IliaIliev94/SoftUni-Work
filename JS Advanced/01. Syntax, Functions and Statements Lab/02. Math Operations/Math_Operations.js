function solve(first, second, operator) {
    let result = operation(first, second, operator);
    console.log(result);
}

function operation(first, second, operator) {
    let result = first;
    switch (operator) {
        case '+':
            result += second;
            break;
        case '-':
            result -= second;
            break;
        case '*':
            result *= second;
            break;
        case '/':
            result /= second;
            break;
        case '%':
            result %= second;
            break;
        case '**':
            result ^= second;
            break;
    }
    return result;
}