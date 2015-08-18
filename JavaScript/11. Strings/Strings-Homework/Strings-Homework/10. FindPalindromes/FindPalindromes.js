/*Problem 10. Find palindromes

Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

var text,
    arrWithWords,
    word,
    i,
    len,
    palindrome,
    result;

text = 'text with palindomes like abba or lamal and something liil or wxw and xas';

arrWithWords = text.split(' ')
.filter(function (word) {
    return !!word;
});

result = [];

for (word in arrWithWords) {
    palindrome = true;
    len = arrWithWords[word].length / 2;
    for (i = 0; i <= len; i += 1) {
        if (arrWithWords[word][i] != arrWithWords[word][arrWithWords[word].length - i - 1]) {
            palindrome = false;
            break;
        }
    }
    if (palindrome) {
        result.push(arrWithWords[word]);
    }
}

console.log(result);