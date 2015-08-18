/*
 * Problem 7. Binary search

Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */
var arr = [],
    key,
    finalIndex,
    returnedValue,
    found,
    index;

arr = [11, 1, 3, 4, 5, 66, 9, 0];
console.log("arr: " + arr.join(", "));
key = 11;
console.log("Search for: " + key);
index = parseInt(arr.length / 2);
finalIndex = index;
arr = arr.sort(function (a, b) { return a - b });
console.log("arr(sorted): " + arr.join(", "));
returnedValue = -1;
found = true;

function BinarySearch(arr, key, index) {
    if (key == arr[index]) {
        if (found) {
            returnedValue = finalIndex;
            found = false;
        }
        return;
    }
    if (key < arr[index]) {
        arr = arr.slice(0, index);
        index = parseInt(arr.length / 2);
        finalIndex -= (arr.length - index);
        BinarySearch(arr, key, index);
    }
    if (key > arr[index]) {
        arr = arr.slice(index + 1, arr.length);
        index = parseInt(arr.length / 2);
        finalIndex += (arr.length - index);
        BinarySearch(arr, key, index);
    }
}

BinarySearch(arr, key, index);
console.log("Returned index: " + returnedValue);