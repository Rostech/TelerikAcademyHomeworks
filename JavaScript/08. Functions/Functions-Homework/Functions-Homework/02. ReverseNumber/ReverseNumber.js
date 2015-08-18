/*
 * Problem 2. Reverse number

Write a function that reverses the digits of given decimal number.
 */

var arr = [256, 123.45],
    i,
    str = '',
    len;

for (i = 0, len = arr.length; i < len; i += 1) {
    console.log(ReverseNumber(arr[i]));
}

function ReverseNumber(number) {
    str = number.toString();
    var strResult = "";
    for (var j = str.length - 1; j >= 0; j -= 1) {
        strResult += str[j];
    }
    return parseFloat(strResult);
}