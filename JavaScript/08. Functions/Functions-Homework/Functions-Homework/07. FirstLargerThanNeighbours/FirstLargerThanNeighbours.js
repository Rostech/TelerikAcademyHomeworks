/*
 * Problem 7. First larger than neighbours

Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
Use the function from the previous exercise.
 */

function LargerThanNeighbours(arr, index) {
    arr = arr || [];
    index = index || 0;

    if (index > 0 && index < arr.length - 1) {
        if (arr[index - 1] < arr[index] && arr[index] > arr[index + 1]) {
            return true;
        } else {
            return false;
        }

    } else {
        return false;
    }
    return false;
}

function FirstLargerThanNeighbours(arr) {
    for (var i = 0, len = arr.length; i < len; i += 1) {
        if (LargerThanNeighbours(arr, i)) {
            return i;
        }
    }
    return -1;
}

var arr1 = [1, 2, 3, 4, 5, 6, 5, 7, 8, 9, 10],
    arr2 = [6, 7, 0, 9, 1],
    arr3 = [1, 2, 3, 4, 5];
console.log("Test1 : " + arr1.join(', '));
console.log('Result: ' + FirstLargerThanNeighbours(arr1));
console.log("Test2 : " + arr2.join(', '));
console.log('Result: ' + FirstLargerThanNeighbours(arr2));
console.log("Test3 : " + arr3.join(', '));
console.log('Result: ' + FirstLargerThanNeighbours(arr3));
