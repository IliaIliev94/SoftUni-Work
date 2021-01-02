const baseUrl = `https://students-500f0.firebaseio.com`;

const loadBtn = document.querySelector('#load');
const addBtn = document.querySelector('#add');
const tbody = document.querySelector('tbody');
addBtn.addEventListener('click', addStudent);

loadBtn.addEventListener('click', loadStudents);

function loadStudents() {
    fetch(`${baseUrl}/students.json`)
        .then(res => res.json())
        .then(data => {
            tbody.innerHTML = Object.values(data)
                .map(el => `<tr><td>${el.id}</td><td>${el.firstName}</td><td>${el.lastName}</td><td>${el.facultyNumber}</td><td>${el.grade}</td></tr>`)
                .join('');
        })
        .catch(err => console.log(err));
}

function addStudent(event) {
    event.preventDefault();
    const id = document.querySelector('#student-id').value;
    const firstName = document.querySelector('#first-name').value;
    const lastName = document.querySelector('#last-name').value;
    const facultyNumber = document.querySelector('#faculty-number').value;
    const grade = document.querySelector('#grade').value;
    if(id === '' || firstName === '' || lastName === '' || facultyNumber === '' || grade === '') {
        return;
    }
    fetch(`${baseUrl}/students.json`, {
        method: 'POST',
        body: JSON.stringify({
            "id": id,
            "firstName": firstName,
            "lastName": lastName,
            "facultyNumber": facultyNumber,
            "grade": grade
        })
    })
        .catch(err => console.log(err));
}

function createElement(element, text) {
    let result = document.createElement(element);
    result.textContent = text;
    return result;
}
