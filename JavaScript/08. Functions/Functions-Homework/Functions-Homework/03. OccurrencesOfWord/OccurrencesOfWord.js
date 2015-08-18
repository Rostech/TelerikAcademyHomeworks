/*
 * Problem 3. Occurrences of word

Write a function that finds all the occurrences of word in a text.
The search can be case sensitive or case insensitive.
Use function overloading.
 */

var str = 'Lorem ipsum,lorem,lorem,lorem dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.';
var word = 'Lorem';

console.log("Text: " + str);
console.log("Insensitive search ot the word: " + word + " => " + OccurrencesOfWord(str, word));
console.log("Sensitive search ot the word: " + word + " => " + OccurrencesOfWord(str, word, true));

function OccurrencesOfWord(text, word, sensitive) {
    sensitive = sensitive || false;
    switch (sensitive) {
        case false:
            return InsensitiveSearch(text, word);
            break;
        case true:
            return SensitiveSearch(text, word);
            break;
        default:
            console.log("Error. Sensitive or insensitive!");
            break;
    }

    function InsensitiveSearch(text, word) {
        var textLow = text.toLowerCase();
        var wordLow = word.toLowerCase();
        var arr = textLow.split(/[\s,.]+/);
        var i, len, count = -1;
        for(i = 0, len = arr.length; i < len; i += 1 ) {
            if (wordLow === arr[i]) {
                count += 1;
            }
        }
        return count +1;
    }

    function SensitiveSearch(text, word) {
        var arr = text.split(/[\s,.]+/);
        var i, len, count = -1;
        for (i = 0, len = arr.length; i < len; i += 1) {
            if (word === arr[i]) {
                count += 1;
            }
        }
        return count + 1;
    }
}
