class SortedList {
    constructor() {
        this.numbers = [];
        this.size = 0;
    }
    add(number) {
        this.numbers.push(number);
        this.size++;
        this.numbers.sort((a, b) => {
            return a - b;
        });
    }
    remove(index) {
        if(index >= 0 && index < this.numbers.length) {
            this.numbers.splice(index, 1);
            this.size--;
            this.numbers.sort((a, b) => {
                return a - b;
            });
        }
    }
    get(index) {
        if(index >= 0 && index < this.numbers.length) {
            this.numbers.sort((a, b) => {
                return a - b;
            });
            return this.numbers[index];
        }
    }
}

let list = new SortedList();
list.add(5);
list.add(6);
list.add(7);
list.add(4);
console.log(list.get(0));
list.remove(1);
console.log(list.get(1));
console.log(list.size)
console.log(list)

