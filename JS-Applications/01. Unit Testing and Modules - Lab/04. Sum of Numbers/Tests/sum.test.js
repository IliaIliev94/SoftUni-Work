const assert = require('chai').assert;
const sum = require('../index').sum;

describe('Checks the functionality of the sum function', function () {
    it('Should take array of numbers as arguments and return a number', () => {
        assert.equal(sum([1, 2]), 3);
    });
    it('Should take an array of negative number and return a negative number', () => {
        assert.equal(sum([-1, -2]), -3);
    });
    it('Should take an array of positive and negative number and return a correct result', () => {
        assert.equal(sum([1, -2]), -1);
    });
});