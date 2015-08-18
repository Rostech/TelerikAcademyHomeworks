/*
 * Problem 4. Number of elements

Write a function to count the number of div elements on the web page
 */

function CountElementsWithTag(tag) {
    var arr = document.getElementsByTagName(tag.toUpperCase());
    return arr.length;
}

console.log(CountElementsWithTag("div"));
