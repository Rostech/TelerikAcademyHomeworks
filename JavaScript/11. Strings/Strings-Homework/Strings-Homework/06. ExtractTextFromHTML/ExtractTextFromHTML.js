/*
 * Problem 6. Extract text from HTML

Write a function that extracts the content of a html page given as text.
The function should return anything that is in a tag, without the tags.
 */

var htmlText;

htmlText = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";

function ExtractContent(text) {
    text = text || '';
    var pattern = /<[a-z]*>|<\/[a-z]*>/;
    var result = text.split(pattern)
    .filter(function (word) {
        return !!word;
    });
    return result.join('');
}

console.log('Result:  ' + ExtractContent(htmlText));

