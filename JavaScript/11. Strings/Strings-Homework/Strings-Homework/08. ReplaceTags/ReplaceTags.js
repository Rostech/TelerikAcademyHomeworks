/*Problem 8. Replace tags

Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/

var text;

text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
console.log("Text before replacing: " + text);

function replaceWithURL(text) {
    text = text || '';
    var pattern = new RegExp('<\/a>', 'g');
    text = text.replace(pattern, '[\/URL]');
    pattern = new RegExp('<a[ a-zA-Z0-9":/.="]*>', 'g', 'i');
    var mathes = text.match(pattern);
    for (var i in mathes) {
        var address = new RegExp('"[a-z://A-Z0-9.]*');
        address = mathes[i].match(address);
        text = text.replace(mathes[i], '[URL=' + address[0].substring(1, address[0].length) + ']');
    }
    return text;
}

text = replaceWithURL(text);
console.log("Text after replacing: " + text);