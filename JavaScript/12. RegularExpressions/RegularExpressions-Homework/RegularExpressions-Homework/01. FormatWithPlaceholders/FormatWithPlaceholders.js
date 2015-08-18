/*
 * Problem 1. Format with placeholders

Write a function that formats a string. The function should have placeholders, as shown in the example
Add the function to the String.prototype
 */

if (!String.prototype.format) {
    String.prototype.format = function (options) {
        var i,
            temp,
            str = this;
        for (i in options) {
            temp = new RegExp('#\{' + i + '\}', 'g');
            str = str.replace(temp, options[i]);
        }
        return str;
    }
}

var str,
    options;

options = { name: 'John' };
str = 'Hello, there! Are you #{name}?';
console.log("First example:");
console.log(str.format(options));
options = {name: 'John', age: 13};
str = 'My name is #{name} and I am #{age}-years-old';
console.log("Second example:");
console.log(str.format(options));
