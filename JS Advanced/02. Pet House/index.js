function solveClasses() {
    class Pet {
        constructor(owner, name) {
            this.owner = owner;
            this.name = name;
            this.comments = [];
        }
        addComment(comment) {
            if(this.comments.includes(comment)) {
                throw 'This comment is already added!';
            }
            this.comments.push(comment);
            return 'Comment is added.'
        }
        feed() {
            return `${this.name} is fed`
        }
        toString() {
            let message = `Here is ${this.owner}'s pet ${this.name}.`;
            if(this.comments.length > 0) {
                message += `\nSpecial requirements: ${this.comments.join(', ')}`;
            }
            return message;
        }
    }
    class Cat extends Pet {
        constructor(owner, name, insideHabits, scratching) {
            super(owner, name);
            this.insideHabits = insideHabits;
            this.scratching = scratching;
        }
        feed() {
            return `${super.feed()}, happy and purring.`;
        }
        toString() {
            let message = super.toString();
            message += `\nMain information:`;
            message += `\n${this.name} is a cat with ${this.insideHabits}`;
            if(this.scratching === true) {
                message += ', but beware of scratches.';
            }
            return message;
        }
    }
    class Dog extends Pet{
        constructor(owner, name, runningNeeds, trainability) {
            super(owner, name);
            this.runningNeeds = runningNeeds;
            this.trainability = trainability;
        }
        feed() {
            return `${super.feed()}, happy and wagging tail.`;
        }
        toString() {
            let message = super.toString();
            message += `\nMain information:`;
            message += `\n${this.name} is a dog with need of ${this.runningNeeds}km running every day and ${this.trainability} trainability.`;
            return message;
        }
    }
    return {
        Pet,
        Cat,
        Dog
    }
}