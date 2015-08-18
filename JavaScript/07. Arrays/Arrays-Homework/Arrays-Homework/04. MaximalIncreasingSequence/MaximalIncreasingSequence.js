/*
 * Problem 4. Maximal increasing sequence

Write a script that finds the maximal increasing sequence in an array.
 */

var arr,
    len,
    index,
    count,
    maxCount,
    i;

arr = [3, 2, 3, 4, 2, 2, 4];

maxCount = 0;
count = 0;
index = 0;

for (i = 0, len = arr.length - 1; i < len; i += 1) {
    if (arr[i] < arr[i + 1]) {
        count += 1;
    } else {
        count = 0;
    }
    if (maxCount < count) {
        maxCount = count;
        index = i - maxCount + 1;
    }
}
maxCount += 1;
console.log("Maximal increasing sequence: " + arr.splice(index, maxCount).join(', '));