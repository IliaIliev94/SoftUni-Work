const assert = require('chai').assert;
let StringBuilder = require('../string-builder.js').StringBuilder;

describe('Unit tests for the constructor of StringBuilder', function () {
    it('should be instantiated with a passed string even if it is empty', function () {
        let cat = new StringBuilder('cat');
        assert.equal(cat.toString(), 'cat');
        assert.equal(new StringBuilder('').toString(), '');
        assert.equal(new StringBuilder(' ').toString(), ' ');
    });
    it('should return an empty string if it is passed undefined', function () {
        assert.equal(new StringBuilder(undefined).toString(), '');
    });
    it('should throw an error if the passed value isn\'t a string', function () {
        assert.throws(() => new StringBuilder(2), TypeError, 'Argument must be string');
        assert.throws(() => new StringBuilder([1, 2, 3]), TypeError, 'Argument must be string');
        assert.throws(() => new StringBuilder({x: 2, y: '3'}), TypeError, 'Argument must be string');
    });
});

describe('Unit tests for the append functionality of the string-builder class', function () {
    let foo = new StringBuilder('foo');
    it('should add the passed in string to the end of the array', function () {
        foo.append('bar');
        assert.equal(foo.toString(), 'foobar');
        foo.append('s');
        assert.equal(foo.toString(), 'foobars');
        foo.append('');
        assert.equal(foo.toString(), 'foobars');
    });
    it('should return an error if the passed argument isn\'t a string', function () {
        assert.throws(() => foo.append(2), TypeError, 'Argument must be string');
        assert.throws(() => foo.append([1, 2, 3]), TypeError, 'Argument must be string');
        assert.throws(() => foo.append({x: 2, y: '3'}), TypeError, 'Argument must be string');
    });
});

describe('Unit tests for the prepend functionality of the stringbuilder class', function () {
    let foo = new StringBuilder('');
    it('should add the passed in string to the beginning of the stringbuilder class', function () {
        foo.prepend('bar');
        assert.equal(foo.toString(), 'bar');
        foo.prepend('foo');
        assert.equal(foo.toString(), 'foobar');
        foo.prepend('');
        assert.equal(foo.toString(), 'foobar');
    });
    it('should return an error if the passed argument isn\'t a string', function () {
        assert.throws(() => foo.prepend(2), TypeError, 'Argument must be string');
        assert.throws(() => foo.prepend([1, 2, 3]), TypeError, 'Argument must be string');
        assert.throws(() => foo.prepend({x: 2, y: '3'}), TypeError, 'Argument must be string');
    });
});

describe('Unit tests for the insertAt functionality of the stringbuilder class', function () {
    let foo = new StringBuilder('fo');
    it('should insert the passed in string at the given index', function () {
        foo.insertAt('o', 1);
        assert.equal(foo.toString(), 'foo')
        foo.insertAt('bar', 0);
        assert.equal(foo.toString(), 'barfoo');
        foo.insertAt('bar', 6);
        assert.equal(foo.toString(), 'barfoobar');
        foo.insertAt('foo', 6);
        assert.equal(foo.toString(), 'barfoofoobar');
    });
    it('should return an error if the passed argument isn\'t a string', function () {
        assert.throws(() => foo.insertAt(2, 0), TypeError, 'Argument must be string');
        assert.throws(() => foo.insertAt([1, 2, 3], 1), TypeError, 'Argument must be string');
        assert.throws(() => foo.insertAt({x: 2, y: '3'}, 2), TypeError, 'Argument must be string');
    });
});

describe('Unit tests for the remove functionality of the stringbuilder class', function () {
    let foo = new StringBuilder('foobar');
    it('should remove the given length of characters starting from the given index', function () {
        foo.remove(3, 3);
        assert.equal(foo.toString(), 'foo');
        foo.remove(1, 1);
        assert.equal(foo.toString(), 'fo');
        foo.remove(0, 2);
        assert.equal(foo.toString(), '');
    });
});

describe('Unit tests for the to string functionality of the stringuilder class', function () {
    let foo = 'foo';
    it('should return the string that the stringbuilder class holds, even if changed', function () {
        assert.equal(foo.toString(), 'foo');
        foo = 'bar';
        assert.equal(foo.toString(), 'bar');
        foo = foo.toUpperCase();
        assert.equal(foo.toString(), 'BAR');
    });
});