const assert = require('chai').assert;
const isSymmetric = require('../index').isSymmetric;

describe('Tests for symmetric function', function () {
    it('Should throw an error if it isn\'t passed an array', () => {
        assert.equal(isSymmetric('1'), false);
    });
    it('Returns true if the array is symmetric', () => {
        assert.equal(isSymmetric([1, 3, 1]), true);
    });
    it('Return false if the array isn\'t symmetric', () => {
        assert.equal(isSymmetric([1, 2, 3]), false);
    });
    it('Return true if the array is empty', () => {
        assert.equal(isSymmetric([]), true);
    });
    it('Returns true if the array is symmetric', () => {
        assert.equal(isSymmetric([1, 'hi', {a: '5'}, 4, {a: '5'}, 'hi', 1]), true);
    });
});