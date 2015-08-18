/*Problem 1. Reverse string

Write a JavaScript function that reverses a string and returns it.*/

function reverseString(string) {
    string = string || '';
    var change = '',
        i = string.length - 1;
    for (; i >= 0; i -= 1) {
        change += string[i];
    }
    return change;
}

reverseString('sample');