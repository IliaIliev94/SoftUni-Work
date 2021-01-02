const assert = require('chai').assert;
const lookupChar = require('../index').lookupChar;

describe('Unit tests for lookupChar function', function () {
    it('should return undefined if the first isn\'t a string or the second a number', function () {
        assert.equal(lookupChar({a: '3'}, 3), undefined);
        assert.equal(lookupChar('2', '4'), undefined);
        assert.equal(lookupChar([1, 2, 3], '3'), undefined);
        assert.equal(lookupChar([1, 2, 3], -1), undefined);
        assert.equal(lookupChar('2', 3.44), undefined);
    });
    it('should return incorrect index if the index is negative or bigger than the string length', function () {
        assert.equal(lookupChar('cat', -1), 'Incorrect index');
        assert.equal(lookupChar('number', 10), 'Incorrect index')
        assert.equal(lookupChar('engineering', 11), 'Incorrect index')
        assert.equal(lookupChar('', 0), 'Incorrect index');
    });
    it('should return the character at the given index if everything is passed correctly', function () {
        assert.equal(lookupChar('cat', 0), 'c');
        assert.equal(lookupChar('number', 3), 'b');
        assert.equal(lookupChar('dog', 2), 'g');
    });
});