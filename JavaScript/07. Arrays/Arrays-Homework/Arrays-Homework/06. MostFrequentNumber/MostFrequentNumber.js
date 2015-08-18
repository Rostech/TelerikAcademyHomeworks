/*
 * Problem 6. Most frequent number

Write a script that finds the most frequent number in an array.
 */

var arr,
    len,
    i,
    j,
    index,
    maxCount,
    count;

arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
index = 0;
count = 0;
maxCount = 0;

for (i = 0, len = arr.length; i < len; i += 1) {
    count = 0;
    for (j = 0; j < len; j += 1) {
        if (arr[i] == arr[j]) {
            count += 1;
        }
    }
    if (maxCount < count) {
        maxCount = count;
        index = i;
    }
}

console.log("Result: " + arr[index] + " ( " + maxCount + " times)");