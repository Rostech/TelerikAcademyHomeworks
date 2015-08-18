/*
 * Problem 8. Number as words

Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
 */

var hunders = 0;
var tens = 0;
var ones = 0;

var numbers = [0, 9, 10, 12, 19, 25, 98, 273, 400, 501, 617, 711, 999];

var result = "";
var finalResult = "";

for (var i = 0; i < numbers.length; i += 1) {
    result = "";
    hunders = parseInt((numbers[i] / 100) % 10);
    tens = parseInt((numbers[i] / 10) % 10);
    ones = parseInt(numbers[i] % 10);

    switch (hunders) {
        case 1:
            result += "One hundred ";
            break;
        case 2:
            result += "Two hundred ";
            break;
        case 3:
            result += "Three hundred ";
            break;
        case 4:
            result += "Four hundred ";
            break;
        case 5:
            result += "Five hundred ";
            break;
        case 6:
            result += "Six hundred ";
            break;
        case 7:
            result += "Seven hundred ";
            break;
        case 8:
            result += "Eight hundred ";
            break;
        case 9:
            result += "Nine hundred ";
            break;
        default: break;
    }

    if (hunders > 0 && (tens > 0 || ones > 0)) {
        result += "and ";
    }

    if (tens === 1) {
        switch (ones) {
            case 0:
                result += "ten ";
                break;
            case 1:
                result += "eleven ";
                break;
            case 2:
                result += "twelve ";
                break;
            case 3:
                result += "thirteen ";
                break;
            case 4:
                result += "fourteen ";
                break;
            case 5:
                result += "fifteen ";
                break;
            case 6:
                result += "sixteen ";
                break;
            case 7:
                result += "seventeen ";
                break;
            case 8:
                result += "eighteen ";
                break;
            case 9:
                result += "nineteen ";
                break;
            default: break;
        }
    } else {
        switch (tens) {
            case 2:
                result += "twenty "
                break;
            case 3:
                result += "thirty "
                break;
            case 4:
                result += "fourty "
                break;
            case 5:
                result += "fifty "
                break;
            case 6:
                result += "sixty "
                break;
            case 7:
                result += "seventy "
                break;
            case 8:
                result += "eighty "
                break;
            case 9:
                result += "ninety "
                break;
            default: break;
        }
    }

    if (ones > 0 && tens != 1) {
        switch (ones) {
            case 0:
                result += "zero ";
                break;
            case 1:
                result += "one ";
                break;
            case 2:
                result += "two ";
                break;
            case 3:
                result += "three ";
                break;
            case 4:
                result += "four ";
                break;
            case 5:
                result += "five ";
                break;
            case 6:
                result += "six ";
                break;
            case 7:
                result += "seven ";
                break;
            case 8:
                result += "eight ";
                break;
            case 9:
                result += "nine ";
                break;
            default: break;
        }
    }
    if (tens == 0 && hunders == 0 && ones == 0) {
        result = "zero";
    }
    
    finalResult = result[0].toString().toUpperCase();
    finalResult += result.substr(1, result.length - 1);
    console.log(numbers[i] + " - " + finalResult);

}