function solve() {
    function Person(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
        Object.defineProperty(this, 'fullName', {
            get: () => {return this.firstName + ' ' + this.lastName;},
            set: (value) => {
                let name = value.split(' ');
                this.firstName = name[0];
                this.lastName = name[1];
            }
        })

    }
    let person = new Person("Georgi", "Vasilev");
    person.firstName = "Ilia";
    person.lastName = "Iliev";
    console.log(person.fullName);
}

solve();
