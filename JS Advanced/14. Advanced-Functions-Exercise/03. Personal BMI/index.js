function solution(name, age, weight, height) {
    let person = {};
    person.name = name;
    person.personalInfo = {age: Number(age), weight: Math.round(Number(weight)),
        height: Math.round(Number(height))};
    person.BMI = Math.round(person.personalInfo.weight / Math.pow(person.personalInfo.height / 100, 2));
    person.status = getStatus.call(person);
    return person;
    function getStatus() {
        const BMI = this.BMI;
        let status = "";
        if(BMI < 18.5) {
            status = "underweight";
        }
        else if(BMI < 25) {
            status = "normal";
        }
        else if(BMI < 30) {
            status = "overweight";
        }
        else {
            status = "obese";
            this.recommendation = "admission required";
        }
        return status;
    }
}

console.log(solution("Peter", 29, 75, 182));