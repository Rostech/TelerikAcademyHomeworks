/*
 * Problem 2. Lexicographically comparison

Write a script that compares two char arrays lexicographically (letter by letter).
 */

var arr1,
    str1,
    str2,
    arr2;

arr1 = ['p', 'e', 's', 'h', 'o'];
arr2 = ['p', 'o', 's', 'h', 'o'];

str1 = arr1.join('');
str2 = arr2.join('');

if (arr1 < arr2) {
    console.log("["+arr1.join(', ') + "] is before [" + arr2.join(', ')+"]");
} else if (arr1 > arr2) {
    console.log("[" + arr2.join(', ') + "] is before " + arr1.join(', ') + "]");
} else {
    console.log("[" + arr1.join(', ') + "] and [" + arr2.join(', ') + "] are equal! ");
}