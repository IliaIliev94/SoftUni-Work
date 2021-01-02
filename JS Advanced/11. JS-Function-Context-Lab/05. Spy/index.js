function Spy(obj, methodName) {
    let originalFunction = obj[methodName];
    let result = {
        count: 0
    }
    obj[methodName] = function() {
        result.count++;
        return originalFunction.apply(this, arguments);
    }
    return result;
}
let myObj = {
    greet: function() {
        console.log('Hi');
    }

}
let spy = Spy(console, 'log');
console.log(spy);
console.log(spy);
console.log(spy);