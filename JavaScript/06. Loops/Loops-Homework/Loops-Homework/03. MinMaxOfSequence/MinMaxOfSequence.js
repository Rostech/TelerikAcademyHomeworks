/*
 * Problem 3. Min/Max of sequence

Write a script that finds the max and min number from a sequence of numbers.
 */

function MaxMinSequence() {
    var sequence = document.getElementById('sequence').value;
    var arr = new Array();
    arr = sequence.split(" ");
    var min = parseInt(arr[0]);
    var max = parseInt(arr[0]);
    for (var i in arr) {
        if (min > parseInt(arr[i]))
            min = parseInt(arr[i]);
        if (max < parseInt(arr[i]))
            max = parseInt(arr[i]);
    }
    document.getElementById('result').innerHTML = "Min: " + min + "  Max: " + max;
}