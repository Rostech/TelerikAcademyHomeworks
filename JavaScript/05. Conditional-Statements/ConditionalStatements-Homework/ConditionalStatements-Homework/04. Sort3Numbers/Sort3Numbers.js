/*
 * 
 * Problem 4. Sort 3 numbers

Sort 3 real values in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.

 */

// Използвам масиви само, за да улесня проверката ползвайки примерите от условията :)

var a = [5, -2, -2, 0, -1.1, 10, 1];
var b = [1, -2, 4, -2.5, -0.5, 20, 1];
var c = [2, 1, 3, 5, -0.1, 30, 1];
var result = "";

for (var i = 0; i < a.length; i += 1) {
    result = "";
    if (a[i] > b[i]) {
        if (a[i] > c[i]) {
            if (c[i] > b[i]) {
                result = a[i] + " " + c[i] + " " + b[i];
            } else {
                result = a[i] + " " + b[i] + " " + c[i];
            }
        } else {
            result = c[i] + " " + a[i] + " " + b[i];
        }
    } else {
        if (b[i] > c[i]) {
            if (c[i] > a[i]) {
                result = b[i] + " " + c[i] + " " + a[i];
            } else {
                result = b[i] + " " + a[i] + " " + c[i];
            }
        } else {
            result = c[i] + " " + b[i] + " " + a[i];
        }
    }
    console.log("a: " + a[i] + " b: " + b[i] + " c: " + "result: " + result);
}