/*
 * Problem 2. Numbers not divisible

Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
 */

function NotDivisible() {
    var result = "";
    var n = document.getElementById('n').value;
    n = parseInt(n);
    if (!isNaN(n)) {
        for (var i = 1; i <= n; i += 1) {
            if(i % 3 != 0 || i % 7 != 0)
                result += i + "<br/>";
        }

    } else {
        result = "NaN";
    }
    document.getElementById('result').innerHTML = result;
}