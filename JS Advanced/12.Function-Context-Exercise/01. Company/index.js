class Company {
    constructor() {
        this.departments = [];
    }

    addEmployee(userName, salary, position, department) {
        if(isEmpty(userName) || isEmpty(salary) || isEmpty(position) || isEmpty(department)) {
            throw 'Invalid input!';
        }
        else if(salary < 0) {
            throw ' Invalid input';
        }
        let newEmployee = {
            userName: userName,
            salary: salary,
            position: position,
            department: department
        }
        if(!this.departments[newEmployee.department]) {
            this.departments[newEmployee.department] = [];
        }

        this.departments[newEmployee.department].push(newEmployee);
        console.log(`New employee is hired. Name: ${userName}. Position: ${position}`)


        function isEmpty(property) {
        return property === null || property === '' || property === undefined;
        }
    }
    bestDepartment() {
        let result = Object.keys(this.departments).sort((a, b) => {
            return getAverageSalary(this.departments[b]) - getAverageSalary(this.departments[a]);
        })[0];
        let finalResult = '';
        finalResult += `Best Department is: ${result}\n`;
        finalResult += `Average salary: ${getAverageSalary(this.departments[result]).toFixed(2)}\n`;
        finalResult += printResult(result, this.departments);
        return finalResult;

        function getAverageSalary(department) {
            let sum = 0;
            department.forEach(employee => {
                sum += employee.salary;
            });
            return sum / department.length;
        }

        function printResult(result, departments){
            let printResult = departments[result].sort((a, b) => {
                if(b.salary > a.salary) {
                    return 1;
                }
                else if(a.salary > b.salary) {
                    return -1;
                }
                else {
                    if(b.userName > a.userName) {
                        return -1;
                    }
                    else {
                        return 1;
                    }
                }
            });
            let myResult = '';
            printResult.forEach(element => myResult += `${element.userName} ${element.salary} ${element.position}\n`);
            return myResult;
        }

    }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());