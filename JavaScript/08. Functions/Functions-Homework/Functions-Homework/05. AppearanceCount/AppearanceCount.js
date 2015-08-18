/*
 * Problem 5. Appearance count

Write a function that counts how many times given number appears in given array.
Write a test function to check if the function is working correctly.
 */

function AppearanceCount(number, arr) {
    number = number || 0;
    arr = arr || [];
    var i,
        count = 0,
        len;
    for (i = 0, len = arr.length; i < len; i += 1) {
        if (arr[i] === number) {
            count += 1;
        }
    }
    return count;
}

function TestAppearanceCount(number, arr, count) {
    arr = arr || [];
    number = number || [];
    count = count || [];
    var result = '';

    if (arguments.length >= 3) {
        result = "Number " + number + " is found " + AppearanceCount(number, arr) + " times and you are expecting: " + count;
    } else if (arguments.length < 3) {
        result = "Wrong parametters!";
    }
    return result;
}

var arr1 = [1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2],
    number1 = 1,
    count1 = 3,
    arr2 = [5, 6, 7, 8, 23, 2, 3, 4, 23, 23, 1, 2, 5, 23],
    number2 = 5,
    count2 = 2;

console.log("Test 1: " + arr1.join(", "));
console.log(TestAppearanceCount(number1, arr1, count1));
console.log("Test 2: " + arr2.join(", "));
console.log(TestAppearanceCount(number2, arr2, count2));