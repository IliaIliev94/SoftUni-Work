const assert = require('chai').assert;
const isOddOrEven = require('../index').isOddOrEven;

describe('Unit tests for oddOrEven function', function () {
    it('should return undefined if passed an argument other than a string', function () {
        assert.equal(isOddOrEven(2), undefined);
        assert.equal(isOddOrEven([1, 2, '3']), undefined);
        assert.equal(isOddOrEven({first: 2, second: '3'}), undefined);
    });
    it('should return odd if the passed string length is odd', function () {
        assert.equal(isOddOrEven('sad'), 'odd');
        assert.equal(isOddOrEven('first'), 'odd');
        assert.notEqual(isOddOrEven('even'), 'odd');
    });
    it('should return even if the passed string length is even', function () {
        assert.equal(isOddOrEven('five'), 'even');
        assert.equal(isOddOrEven('even'), 'even');
        assert.notEqual(isOddOrEven('odd'), 'even');
    });
});