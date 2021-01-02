function factory(face, suit) {
    let card = {
        face: createFace(face),
        suit: createSuit(suit),
        toString: function () {
            return this.face + this.suit;
        }
    };
    return card;
    function createFace(face) {
        const faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A']
        if(!faces.includes(face)) {
            throw 'Error';
        }
        return face.toUpperCase();
    }
    function createSuit(suit) {
        const codeSuites = {
            "S": "\u2660",
            "H": "\u2665",
            "D": "\u2666",
            "C": "\u2663"
        };
        if(!codeSuites[suit]) {
            throw "Error";
        }
        return codeSuites[suit].toUpperCase();
    }
}

console.log(factory('1', 'C').toString())