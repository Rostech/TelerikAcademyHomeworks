/*
 * Problem 3. Sub-string in text

Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 */

var text,
    retult;

text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

function countSubstirngContains(text, substring) {
    text = text || '';
    var pattern;

    pattern = new RegExp(substring, 'g', 'i');
    return text.match(pattern).length;
}

result = countSubstirngContains(text, 'in');
console.log('"in"' + ' is repeating ' + result + ' times in the text');