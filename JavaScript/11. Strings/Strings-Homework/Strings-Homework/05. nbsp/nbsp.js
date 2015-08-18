/*Problem 5. nbsp

Write a function that replaces non breaking white-spaces in a text with &nbsp;*/

var text,
    replace;

text = 'Write a function that replaces non breaking white-spaces in a text with &nbsp;';
replace = '&nbsp;';
console.log('text before: ' + text);

function replaseWhiteSpaces(text, replaceText) {
    text = text || '';
    while(text.replace(' ', replaceText) != text){
        text = text.replace(' ', replaceText);
    }
    return text;
}

text = replaseWhiteSpaces(text, replace);
console.log('text after: ' + text);