/*Problem 4. Parse tags

You are given a text. Write a function that changes the text in all regions:
<upcase>text</upcase> to uppercase.
<lowcase>text</lowcase> to lowercase
<mixcase>text</mixcase> to mix casing(random)
*/

if (!String.prototype.mixedCase) {
    String.prototype.toMixedCase = function () {
        text = text || '';
        var i,
            len,
            rand,
            newText = '';
        for (i = 0, len = this.length; i < len; i += 1) {
            rand = Math.floor(Math.random() * 10);
            if (rand % 2 === 0) {
                newText += this[i].toUpperCase();
            } else {
                newText += this[i].toLowerCase();
            }
        }
        return newText;
    }
}

var text,
    pattern;

text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";
console.log("text before change: " + text);
pattern = /<mixcase>[a-zA-Z0-9!._?:,()"\' ]*<\/mixcase>|<upcase>[a-zA-Z0-9!._()"\' ]*<\/upcase>|<lowcase>[a-zA-Z0-9!._()"\' ]*<\/lowcase>/;

function changeTextInRegion(text, pattern) {
    while (text.match(pattern) != null) {
        var arr = text.match(pattern);
        text = text.replace(arr[0], replaceText(text, arr[0]));
    }
    return text;
}

function replaceText(text, stringToReplace) {
    var pt, ar;
    switch (stringToReplace[1]) {
        case 'm':
            pt = /<mixcase>|<\/mixcase>/;
            ar = stringToReplace.split(pt)
            .filter(function (word) {
                return !!word;
            });
            return ar[0].toString().toMixedCase();
        case 'u':
            pt = /<upcase>|<\/upcase>/;
            ar = stringToReplace.split(pt)
            .filter(function (word) {
                return !!word;
            });
            return ar[0].toString().toUpperCase();
        case 'l':
            pt = /<lowcase>|<\/lowcase>/;
            ar = stringToReplace.split(pt)
            .filter(function (word) {
                return !!word;
            });
            return ar[0].toString().toLowerCase();
        default:
            console.log('Error!');
            break;
    }
}

text = changeTextInRegion(text, pattern);
console.log("text after change: " + text);