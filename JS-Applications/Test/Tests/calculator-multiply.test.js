const expect = require('chai').expect;
const calculator = require('../calculator');

describe('Calc Multiply', function () {
    it('Should return positive number when multiplying two positive numbers', () => {
        let result = calculator.multiply(2, 5);
        expect(result).to.equal(10);
    });
});