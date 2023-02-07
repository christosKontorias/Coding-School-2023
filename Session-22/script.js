
/* Question 1*/
function reverseString(str) {
    return str.split("").reverse().join("");
}

document.getElementById("reverseButton").addEventListener("click", function () {
    var inputQuestion1 = document.getElementById("inputQuestion1").value;
    var reversedString = reverseString(inputQuestion1);
    document.getElementById("outputQuestion1").innerHTML = "Reversed: " + reversedString;
});

/* Question 2*/

function isPalindrome(str) {
    var reverseString = str.split("").reverse().join("");
    return reverseString === str;
}

document.getElementById("checkButton").addEventListener("click", function () {
    var inputString = document.getElementById("inputQuestion2").value;
    if (isPalindrome(inputString)) {
        document.getElementById("outputQuestion2").innerHTML = "The string is a palindrome.";
    } else {
        document.getElementById("outputQuestion2").innerHTML = "The string is not a palindrome.";
    }
});

/* Question 3*/

let customers = [];

function saveCustomer() {
    let name = document.querySelector('#name').value;
    let surname = document.querySelector('#surname').value;
    let age = document.querySelector('#age').value;
    let gender = document.querySelector('#gender').value;

    customers.push({ name, surname, age, gender });
    renderCustomers();
}

function renderCustomers() {
    let customerTableBody = document.querySelector('#customerTableBody');
    customerTableBody.innerHTML = '';

    customers.forEach(customer => {
        let tr = document.createElement('tr');
        tr.innerHTML = `
      <td>${customer.name}</td>
      <td>${customer.surname}</td>
      <td>${customer.age}</td>
      <td>${customer.gender}</td>
    `;
        tr.addEventListener('click', () => {
            renderCustomerDetails(customer);
        });
        customerTableBody.appendChild(tr);
    });
}

function renderCustomerDetails(customer) {
    let displayName = document.querySelector('#displayName');
    let displaySurname = document.querySelector('#displaySurname');
    let displayAge = document.querySelector('#displayAge');
    let displayGender = document.querySelector('#displayGender');

    displayName.value = customer.name;
    displaySurname.value = customer.surname;
    displayAge.value = customer.age;
    displayGender.value = customer.gender;
}

/* Question 4*/

function multiply(a, b) {
    if (isNaN(a) || isNaN(b)) {
        return "Both parameters must be numbers.";
    } else {
        return a * b;
    }
}

const multiplyBtn = document.getElementById("multiply");
multiplyBtn.addEventListener("click", function () {
    const numberA = parseInt(document.getElementById("numberA").value);
    const numberB = parseInt(document.getElementById("numberB").value);
    const result = multiply(numberA, numberB);
    document.getElementById("outputQuestion4").innerHTML = "Result: " + result;
});


/* Question 5*/

function modifyString(str) {
    const match = str.match(/\d+$/);
    if (match) {
        const number = parseInt(match[0]) + 1;
        return str.substring(0, str.lastIndexOf(match[0])) + number;
    } else {
        return str + "1";
    }
}

const modifyBtn = document.getElementById("modify");
modifyBtn.addEventListener("click", function () {
    const inputQuestion5 = document.getElementById("inputQuestion5").value;
    const outputQuestion5 = modifyString(inputQuestion5);
    document.getElementById("outputQuestion5").innerHTML = "Modified string: " + outputQuestion5;
});