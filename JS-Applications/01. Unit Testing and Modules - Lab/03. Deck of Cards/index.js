function deckOfCards(cards) {
    let result = cards.map(el => factory(el.substr(0, el.length - 1), el[el.length - 1]).toString());
    console.log(result.join(' '));
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
                return`Invalid card: ${face}${suit}`;
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
                return`Invalid card: ${face}${suit}`;
            }
            return codeSuites[suit].toUpperCase();
        }
    }
}

console.log(deckOfCards(["5S", "3D", "QD", "1C"]));
