const assert = require('chai').assert;
const calculator = require('../calculator');

describe('Calc Sum', function () {
    it('Should return positive number when adding two positive numbers', () => {
        //Arrange
        let firstNumber = 1;
        let secondNumber = 5;
        //Act
        let result = calculator.sum(firstNumber, secondNumber);
        //Assert
        assert.equal(result, 6);
    });
    it('Should return negative number when adding two negative numbers', () => {
        let result = calculator.sum(-10, -5);
        assert.equal(result, -15);
    });
});