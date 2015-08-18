/*
 * Problem 1. Numbers

Write a script that prints all the numbers from 1 to N.
 */

function fromOnetoN() {
    var result = "";
    var n = document.getElementById('n').value;
    n = parseInt(n);
    if (!isNaN(n)) {
        for (var i = 1; i <= n; i += 1) {
            result += i + "<br/>";
        }

    } else {
        result = "NaN";
    }
    document.getElementById('result').innerHTML = result;
}