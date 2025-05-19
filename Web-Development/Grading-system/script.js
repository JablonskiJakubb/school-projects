const correctUsername = "User";
const correctPassword = "Pass";

let students = [];

function login() {
  const user = document.getElementById("username").value;
  const pass = document.getElementById("password").value;
  const error = document.getElementById("login-error");

  if (user === correctUsername && pass === correctPassword) {
    document.getElementById("login-page").style.display = "none";
    document.getElementById("dashboard").style.display = "block";
    updateStudentList();
  } else {
    error.textContent = "Incorrect login!";
  }
}

function addStudent() {
  const name = document.getElementById("new-student-name").value.trim();
  if (name) {
    students.push({ name: name, gradeCount: 0 });
    updateStudentList();
    document.getElementById("new-student-name").value = "";
  }
}

function addPlus(index) {
  students[index].gradeCount += 1;
  updateStudentList();
}

function removePlus(index) {
  if (students[index].gradeCount > 0) {
    students[index].gradeCount -= 1;
    updateStudentList();
  }
}

function updateStudentList() {
  const list = document.getElementById("student-list");
  list.innerHTML = "";

  students.forEach((student, index) => {
    const li = document.createElement("li");
    li.innerHTML = `
      ${student.name} ilość plusów: ${student.gradeCount}
      <button onclick="addPlus(${index})">Dodaj +</button>
      <button onclick="removePlus(${index})">Usuń +</button>
    `;
    list.appendChild(li);
  });
}
