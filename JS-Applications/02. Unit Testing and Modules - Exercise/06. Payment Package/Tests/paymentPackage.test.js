const assert = require('chai').assert;
const PaymentPackage = require('../index').PaymentPackage;

describe('Unit tests for the constructor of the payment package class', function () {
    it('should be able to be instantiated with a string and a number', function () {
        let payment = new PaymentPackage('test', 20);
        let value = [
            `Package: test` + '',
            `- Value (excl. VAT): 20`,
            `- Value (VAT 20%): ${20 * (1 + 20 / 100)}`
        ].join('\n');
        assert.equal(payment.toString(), value);
    });
});

describe('Unit test for the name property of the payment package class', function () {
    let payment = new PaymentPackage('test', 20);
    it('should change the name if the passed argument is a string and isn\'t empty', function () {
        payment.name = 'new name';
        assert.equal(payment.name, 'new name');
        payment.name = 'test2';
        assert.equal(payment.name, 'test2');
    });
    it('should throw an error if the passed in argument isn\'t a string', function () {
        assert.throws(() => payment.name = 2, Error, 'Name must be a non-empty string');
        assert.throws(() => payment.name = [1, 'a', false], Error, 'Name must be a non-empty string');
        assert.throws(() => payment.name = {a: '2', b: 2}, Error, 'Name must be a non-empty string');
    });
    it('should throw an error if the passed in string is empty', function () {
        assert.throws(() => payment.name = '', Error, 'Name must be a non-empty string');
    });
});

describe('Unit test for the value property of the payment package class', function () {
    let payment = new PaymentPackage('test', 20);
    it('should change the name if the passed argument is a number and isn\'t negative', function () {
        payment.value = 3.5;
        assert.equal(payment.value, 3.5);
        payment.value = 100;
        assert.equal(payment.value, 100);
    });
    it('should throw an error if the passed in argument isn\'t a number', function () {
        assert.throws(() => payment.value = 'test', Error, 'Value must be a non-negative number');
        assert.throws(() => payment.value = [1, 'a', false], Error, 'Value must be a non-negative number');
        assert.throws(() => payment.value = {a: '2', b: 2}, Error, 'Value must be a non-negative number');
    });
    it('should throw an error if the passed in number is negative', function () {
        assert.throws(() => payment.value = -2, Error, 'Value must be a non-negative number');
        assert.throws(() => payment.value = -10, Error, 'Value must be a non-negative number');
    });
});

describe('Unit tests for the VAT property of the payment package class', function () {
    let payment = new PaymentPackage('test', 20);
    it('should change the VAT if the passed argument is a number and isn\'t negative', function () {
        payment.VAT = 4.5;
        assert.equal(payment.VAT, 4.5);
        payment.VAT = 110;
        assert.equal(payment.VAT, 110);
    });
    it('should throw an error if the passed in argument isn\'t a number', function () {
        assert.throws(() => payment.VAT = 'value', Error, 'VAT must be a non-negative number');
        assert.throws(() => payment.VAT = [1, 'a', true], Error, 'VAT must be a non-negative number');
        assert.throws(() => payment.VAT = {x: 'bas', y: [1, 2, 3]}, Error, 'VAT must be a non-negative number');
    });
    it('should throw an error if the passed in number is negative', function () {
        assert.throws(() => payment.VAT = -105, Error, 'VAT must be a non-negative number');
        assert.throws(() => payment.VAT = -10.5, Error, 'VAT must be a non-negative number');
    });
});

describe('Unit tests for the active property of the payment package class', function () {
    let payment = new PaymentPackage('test', 20);
    it('should change the active property if the passed argument is a boolean', function () {
        payment.active = false;
        assert.equal(payment.active, false);
        payment.active = true;
        assert.equal(payment.active, true);
    });
    it('should throw an error if the passed in value isn\'t a boolean', function () {
        assert.throws(() => payment.active = 1, Error, 'Active status must be a boolean');
        assert.throws(() => payment.active = [1, 2, 3], Error, 'Active status must be a boolean');
        assert.throws(() => payment.active = {x: 3, a: '2'}, Error, 'Active status must be a boolean');
    });
});

describe('Unit tests for the to toString functionality of the payment package class', function () {
    it('should display the current state of the properties of the class', function () {
        let payment = new PaymentPackage('Prototype', 40);
        let value = [
            `Package: Prototype` + '',
            `- Value (excl. VAT): 40`,
            `- Value (VAT 20%): ${40 * (1 + 20 / 100)}`
        ].join('\n');
        assert.equal(payment.toString(), value);
        payment.name = 'Test';
        payment.VAT = 10;
        value = [
            `Package: Test` + '',
            `- Value (excl. VAT): 40`,
            `- Value (VAT 10%): ${40 * (1 + 10 / 100)}`
        ].join('\n');
        assert.equal(payment.toString(), value);
    });

});