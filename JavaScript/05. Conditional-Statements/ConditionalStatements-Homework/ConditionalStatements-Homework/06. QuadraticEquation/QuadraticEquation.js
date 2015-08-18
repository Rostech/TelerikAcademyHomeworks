/*
 * Problem 6. Quadratic equation

Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.
Note: Quadratic equations may have 0, 1 or
 */

function quadraticEquation() {
    var a = parseFloat(document.getElementById('a').value);
    var b = parseFloat(document.getElementById('b').value);
    var c = parseFloat(document.getElementById('c').value);
    var x1 = 0, x2 =0 , D =0;

    console.log(b);

    if (!isNaN(a) && !isNaN(b) && !isNaN(c)) {
        D = Math.pow(b, 2) - (4 * a * c);
        if (D === 0) { // one real root
            x1 = (-b) / (2 * a);
            console.log("x1 = x2 = " + x1);
        } else if(D > 0) { // two real roots
            x1 = ((-b) - Math.sqrt(D)) / (2 * a);
            x2 = ((-b) + Math.sqrt(D)) / (2 * a);
            console.log("x1 = " + x1 + ",  x2 = " + x2);
        } else {
            console.log("no real roots");
        }
    } else {
        console.log("a or b or c is not a number!");
    }
}