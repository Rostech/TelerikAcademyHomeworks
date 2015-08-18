/*
 * Problem 5. Selection sort

Sorting an array means to arrange its elements in increasing order.
Write a script to sort an array.
Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */



var arr,
    min,
    index,
    change,
    i,
    j;

arr = [1, 2, 3, 64, 22, 25, 10, 15, -1, -2, -9];
min = arr1[0];
index = 0;
change = 0;

for (var i = 0; i < arr.length; i += 1) {
    min = arr[i];
    for (var j = i; j < arr.length; j += 1) {
        if (min >= arr[j]) {
            min = arr[j];
            index = j;
        }
    }
    change = arr[i];
    arr[i] = arr[index];
    arr[index] = change;
}

console.log("Sorted: " + arr.join(', '));