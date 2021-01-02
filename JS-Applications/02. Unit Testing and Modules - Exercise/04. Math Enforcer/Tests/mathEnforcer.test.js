const assert = require('chai').assert;
const mathEnforcer = require('../index').mathEnforcer;

describe('mathEnforcer', function () {
    describe('addFive', function () {
        it('should return undefined if the parameter isn\'t a number', function () {
            assert.equal(mathEnforcer.addFive('5'), undefined);
            assert.equal(mathEnforcer.addFive([1, 2, 3]), undefined);
            assert.equal(mathEnforcer.addFive({a: 's', b: 3}), undefined);
        });
        it('should return the number plus five if the passed parameter is a number', function () {
            assert.equal(mathEnforcer.addFive(2), 7);
            assert.equal(mathEnforcer.addFive(20), 25);
            assert.equal(mathEnforcer.addFive(-5), 0);
            assert.equal(mathEnforcer.addFive(2.5), 7.5);
        });
    });
    describe('subtractTen', function () {
        it('should return undefined if the parameter isn\'t a number', function () {
            assert.equal(mathEnforcer.subtractTen('5'), undefined);
            assert.equal(mathEnforcer.subtractTen([1, 2, 3]), undefined);
            assert.equal(mathEnforcer.subtractTen({a: 's', b: 3}), undefined);
        });
        it('should return the number minus ten if the passed parameter is a number', function () {
            assert.equal(mathEnforcer.subtractTen(11), 1);
            assert.equal(mathEnforcer.subtractTen(-11), -21);
            assert.equal(mathEnforcer.subtractTen(1), -9);
            assert.equal(mathEnforcer.subtractTen(10.5), 0.5);
        });
    });
    describe('sum', function () {
        it('should return undefined if the parameter isn\'t a number', function () {
            assert.equal(mathEnforcer.sum('5', 3), undefined);
            assert.equal(mathEnforcer.sum(5, '2'), undefined);
            assert.equal(mathEnforcer.sum([1, 2, 3], {a: 3}), undefined);
            assert.equal(mathEnforcer.sum({a: 's', b: 3}, false), undefined);
        });
        it('should return the sum of the two numbers', function () {
            assert.equal(mathEnforcer.sum(11, 10), 21);
            assert.equal(mathEnforcer.sum(-11, -2), -13);
            assert.equal(mathEnforcer.sum(2, 0.5), 2.5);
            assert.equal(mathEnforcer.sum(10.5, 2.2), 12.7);
        });
    });
});