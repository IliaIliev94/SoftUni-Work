function solution(argument) {
    let functions = {
        upvote: () => this.upvotes++,
        downvote: () => this.downvotes++,
        score: () => {
            if(this.upvotes + this.downvotes > 50) {
                let percentageIncrease = Math.ceil(Math.max(this.upvotes, this.downvotes) * 0.25);
                return [this.upvotes + percentageIncrease, this.downvotes + percentageIncrease, this.upvotes - this.downvotes, getScore(this.upvotes, this.downvotes)]
            }
            return [this.upvotes, this.downvotes, this.upvotes - this.downvotes, getScore(this.upvotes, this.downvotes)]
        }

    }
    return functions[argument]();

    function getScore(positiveVotes, negativeVotes) {
        if(positiveVotes + negativeVotes >= 10) {
            if(positiveVotes/(positiveVotes + negativeVotes) * 100 > 66) {
                return 'hot';
            }
            else if((positiveVotes > 100 || negativeVotes > 100) && positiveVotes - negativeVotes >= 0) {
                return 'controversial';
            }
            else if(positiveVotes - negativeVotes < 0) {
                return 'unpopular';
            }
        }
        return 'new';
    }
}

let post = {
    id: "3",
author: "emil",
content: "wazaaaaa",
upvotes: 100,
    downvotes: 100
};

solution.call(post, 'upvote');
solution.call(post, 'downvote');
let score = solution.call(post, 'score');
console.log(score);
for(let i = 0; i < 50; i++) {
    solution.call(post, 'downvote');
}
score = solution.call(post, 'score');
console.log(score);
