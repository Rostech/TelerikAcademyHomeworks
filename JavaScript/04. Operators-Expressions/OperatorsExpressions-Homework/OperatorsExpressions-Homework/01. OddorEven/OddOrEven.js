/*
 * Problem 1. Odd or Even

Write an expression that checks if given integer is odd or even.
 */

var numbers = [3, 2, -2, -1, 0];

for (var i = 0; i < numbers.length; i += 1)
{
    console.log(numbers[i] % 2  != 0 ? (numbers[i] + " is odd") : (numbers[i] + " is even"));
}

