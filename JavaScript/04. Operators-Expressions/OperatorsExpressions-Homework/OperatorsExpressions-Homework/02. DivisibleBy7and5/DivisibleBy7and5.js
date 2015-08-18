/*
 * Problem 2. Divisible by 7 and 5

Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
 */

var numbers = [3, 0, 5, 7, 35, 140];

for (var i = 0; i < numbers.length; i += 1) {
    console.log((numbers[i] % 7 == 0 && numbers[i] % 5 == 0) ?
        (numbers[i] + " is divided by 7 and 5") : (numbers[i] + " is NOT divided by 7 and 5"));

}