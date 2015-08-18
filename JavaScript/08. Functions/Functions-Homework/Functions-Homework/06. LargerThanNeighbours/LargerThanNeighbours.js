/*
 * Problem 6. Larger than neighbours

Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

 */

function LargerThanNeighbours(arr, index) {
    arr = arr || [];
    index = index || 0;

    var result = '';

    if (index > 0 && index < arr.length - 1) {
        if (arr[index - 1] < arr[index] && arr[index] > arr[index + 1]) {
            result = "The element " + arr[index] + " is bigger than its two neighbours -> (" + arr.slice(index - 1, index + 2) + ")";
        } else {
            result = "The element " + arr[index] + " is NOT bigger than its two neighbours -> (" + arr.slice(index - 1, index + 2) + ")";
        }

    } else {
        result = 'Neighbour elements does not exist!';
    }
    return result;
}

var arr = [1, 2, 3, 2, 1],
    index1 = 2,
    index2 = 3;

console.log("Test1 index = " + index1);
console.log(LargerThanNeighbours(arr, index1));
console.log("Test2 index = " + index2);
console.log(LargerThanNeighbours(arr, index2));