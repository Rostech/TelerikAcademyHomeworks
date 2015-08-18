/*
 * Problem 5. Digit as word

Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
 */

function numberInEnglish() {
    var input = document.getElementById('number').value;
    var result = "";

    switch (input) {
        case "0":
            input += " zero";
            break;
        case "1":
            input += " one";
            break;
        case "2":
            input += " two";
            break;
        case "3":
            input += " three";
            break;
        case "4":
            input += " four";
            break;
        case "5":
            input += " five";
            break;
        case "6":
            input += " six";
            break;
        case "7":
            input += " seven";
            break;
        case "8":
            input += " eight";
            break;
        case "9":
            input += " nine";
            break;
        default:
            input += " not a digit";
            break;
    }
    console.log(input);
}