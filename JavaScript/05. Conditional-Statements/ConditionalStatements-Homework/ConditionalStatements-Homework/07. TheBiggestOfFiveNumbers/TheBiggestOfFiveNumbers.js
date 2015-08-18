/*
 * Problem 7. The biggest of five numbers

Write a script that finds the greatest of given 5 variables.
Use nested if statements.
 */

var a = [5, -2, -2, 0, -3];
var b = [2, -22, 4, -2.5, -0.5];
var c = [2, 1, 3, 0, -1.1];
var d = [4, 0, 2, 5, -2];
var e = [1, 0, 0, 5, -0.1];
var result = "";

for (var i = 0; i < a.length; i += 1) {
    result = "a: " + a[i] + " b: " + b[i] + " c: " + c[i] + " d: " + d[i] + " e: " + e[i] + " biggest: ";
    if (a[i] >= b[i]) {
        if (a[i] >= c[i]) {
            if (a[i] >= d[i]) {
                if (a[i] >= e[i]) {
                    result += a[i];
                } else {
                    result += e[i];
                }
            } else {
                if (d[i] >= e[i]) {
                    result += d[i];
                } else {
                    result += e[i];
                }
            }
        } else {
            if (c[i] >= d[i]) {
                if (c[i] >= e[i]) {
                    result += c[i];
                } else {
                    result += e[i];
                }
            } else {
                if (d[i] >= e[i]) {
                    result += d[i];
                } else {
                    result += e[i];
                }
            }
        }
    } else {
        if (b[i] >= c[i]) {
            if (b[i] >= d[i]) {
                if (b[i] >= e[i]) {
                    result += b[i];
                } else {
                    result += e[i];
                }
            } else {
                if (d[i] >= e[i]) {
                    result += d[i];
                } else {
                    result += e[i];
                }
            }
        } else {
            if (c[i] >= d[i]) {
                if (c[i] >= e[i]) {
                    result += c[i];
                } else {
                    result += e[i];
                }
            } else {
                if (d[i] >= e[i]) {
                    result += d[i];
                } else {
                    result += e[i];
                }
            }
        }
    }
    console.log(result);
}