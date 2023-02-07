
/* Question 1*/
function reverseString(str) {
    return str.split("").reverse().join("");
}

document.getElementById("reverseButton").addEventListener("click", function () {
    var input = document.getElementById("input").value;
    var reversedString = reverseString(input);
    document.getElementById("output").innerHTML = "Reversed: " + reversedString;
});

/* Question 2*/

function isPalindrome(str) {
    var reverseString = str.split("").reverse().join("");
    return reverseString === str;
}

document.getElementById("checkButton").addEventListener("click", function () {
    var inputString = document.getElementById("inputPalindrome").value;
    if (isPalindrome(inputString)) {
        document.getElementById("outputPalindrome").innerHTML = "The string is a palindrome.";
    } else {
        document.getElementById("outputPalindrome").innerHTML = "The string is not a palindrome.";
    }
});

/* Question 3*/

/* Question 4*/

function multiply(a, b) {
    return a * b;
  }

  const multiplyBtn = document.getElementById("multiply");
  multiplyBtn.addEventListener("click", function() {
    const numberA = parseInt(document.getElementById("numberA").value);
    const numberB = parseInt(document.getElementById("numberB").value);
    const result = multiply(numberA, numberB);
    document.getElementById("result").innerHTML = "Result: " + result;
  });
  
/* Question 5*/
