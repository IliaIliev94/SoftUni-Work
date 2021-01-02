function extendPrototype(classToExtend) {
    classToExtend.prototype.species = "Human";
    classToExtend.prototype.toSpeciesString = function() {
        return `I am a ${classToExtend.prototype.species}. ${this.toString()}`;
    }
}