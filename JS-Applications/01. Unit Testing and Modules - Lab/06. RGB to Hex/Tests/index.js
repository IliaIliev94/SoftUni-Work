const assert = require('chai').assert;
const rgbToHexColor = require('../index').rgbToHexColor;

describe('Tests', function () {
    it('should return undefined if red color not a number', () => {
        assert.equal(rgbToHexColor(false, 2, 3), undefined);
    });
    it('should return undefined if red color is not an integer', () => {
        assert.equal(rgbToHexColor(2.3, 2, 3), undefined);
    })
    it('should return undefined if red color is less than 0', () => {
        assert.equal(rgbToHexColor(-1, 2, 3), undefined);
    });
    it('should return undefined if red color is more than 255', () => {
        assert.equal(rgbToHexColor(256, 2, 3), undefined);
    });
    it('should return undefined if green color is not a number', () => {
        assert.equal(rgbToHexColor(1, [1, 2, 3, 4], 2), undefined);
    });
    it('should return undefined if green color is not an integer', () => {
        assert.equal(rgbToHexColor(1, 3.88, 2), undefined);
    });
    it('should return undefined if green color is less than 0', () => {
        assert.equal(rgbToHexColor(1, -1, 2), undefined);
    });
    it('should return undefined if green color is more than 255', () => {
        assert.equal(rgbToHexColor(1, 300, 2), undefined);
    })
    it('should return undefined if blue color is not a number', () => {
        assert.equal(rgbToHexColor(1, 2, {a: '3'}), undefined);
    });
    it('should return undefined if blue color is not a number', () => {
        assert.equal(rgbToHexColor(1, 2, 5.978), undefined);
    });
    it('should return undefined if blue color is less than 0', () => {
        assert.equal(rgbToHexColor(1, 2, -1), undefined);
    });
    it('should return undefined if one of the colors is more than 255', () => {
        assert.equal(rgbToHexColor(1, 2, 256), undefined);
    });
    it('should return hexadecimal color', () => {
        assert.equal(rgbToHexColor(255, 255, 255).length, 7)
    });
    it('should return hexadecimal color', () => {
        assert.equal(rgbToHexColor(105, 95, 220), '#695FDC')
    });
    it('should return hexadecimal color', () => {
        assert.notEqual(rgbToHexColor(255, 158, 170), '#FFFFFF')
    });
    it('should return hexadecimal color', () => {
        assert.notEqual(rgbToHexColor(255, 255, 255), '#ffffff')
    });
    it('should return hexadecimal color', () => {
        assert.equal(rgbToHexColor(0, 49, 255), '#0031FF')
    });
});