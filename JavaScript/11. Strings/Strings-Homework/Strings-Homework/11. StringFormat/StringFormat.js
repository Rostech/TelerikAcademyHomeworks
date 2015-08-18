/*Problem 11. String format

Write a function that formats a string using placeholders.
The function should work with up to 30 placeholders and all types.*/

function stringFormat() {
    var string = arguments[0];
    var regex;
    for (var i = 1; i < arguments.length; i += 1) {
        regex = new RegExp('\\{' + (i-1) + '\\}', 'g');
        string = string.replace(regex, arguments[i]);
    }
    return string;
}

var str,
    frmt,
    i;

str = stringFormat('Hello {0}!', 'Peter');
console.log(str);
frmt = '{0}, {1}, {0} text {2}';
str = stringFormat(frmt, 1, 'Pesho', function () { return 'Georgi';    });
console.log(str);
console.log('\n Work with 30 placeholders: \n');
str = '';
for (i = 0; i < 30; i += 1) {
    str += 'Text : {' + i + '} \n';
}

console.log(stringFormat(str, 1, 'o', null, NaN, undefined, {}, typeof [], [1,2,3], 'a', 0, 9, 8, 7, 6, 5, 4, 3, 2, 'must to be 30 things ala bala', 2,
    '222', 123.23, 1,2,3,4,5,6,7,8));
