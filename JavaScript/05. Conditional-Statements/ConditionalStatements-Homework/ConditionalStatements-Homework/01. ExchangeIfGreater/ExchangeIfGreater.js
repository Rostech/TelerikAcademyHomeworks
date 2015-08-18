/*
 * Problem 1. Exchange if greater

Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
As a result print the values a and b, separated by a space.
 */

var a = [5, 3, 5.5];
var b = [2, 4, 4.5];
var result = "";

for (var i = 0; i < a.length; i += 1) {
    result = "a: " + a[i] + " b: " + b[i];
    if (a[i] > b[i]) {
        var exchange = a[i];
        a[i] = b[i];
        b[i] = exchange;
    }
    result += " result: " + a[i] + " " + b[i];
    console.log(result);
}