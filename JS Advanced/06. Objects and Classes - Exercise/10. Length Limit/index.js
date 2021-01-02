class Stringer {
    constructor(word, length) {
        this.initialString = word;
        this.CurrentString = word;
        this.Length = length;
    }

    get Length() {
        return this.innerLength;
    }
    get CurrentString() {
        return this.innerString;
    }
    set CurrentString(value) {
        this.innerString = value;
    }
    set Length(value) {
        if(value < 0) {
            this.innerLength = 0;
        }
        else {
            this.innerLength = value;
        }
    }
    increase(number) {
        for(let i = 0, j = this.CurrentString.length; i < number; i++) {
            if(this.CurrentString.length < this.initialString.length) {
                this.CurrentString += this.initialString[j];
                j++;
            }
            this.Length++;
        }
    }
    decrease(number) {
        for(let i = 0; i < number; i++) {
            if(this.Length <= this.CurrentString.length) {
                this.CurrentString = this.CurrentString.substr(0, this.CurrentString.length - 1);
            }
            this.Length--;
        }
    }
    toString() {
        if(this.CurrentString.length < this.initialString.length) {
            return this.CurrentString + '...';
        }
        return this.CurrentString;
    }
}

let test = new Stringer("Test", 5);
console.log(test.toString());
test.decrease(3);
console.log(test.toString());
test.decrease(5);
console.log(test.toString());
test.increase(4);
console.log(test.toString());
