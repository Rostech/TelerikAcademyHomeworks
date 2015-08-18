/*
 * Problem 4. Lexicographically smallest

Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
 */
var arrDoc = [];
for (var property in document) {
    arrDoc.push(property);
}
arrDoc.sort();
console.log('document: ');
console.log('min: ' + arrDoc[0]);
console.log('max: ' + arrDoc[arrDoc.length - 1]);
arrDoc = [];
for (var property in window) {
    arrDoc.push(property);
}
arrDoc.sort();
console.log('window: ');
console.log('min: ' + arrDoc[0]);
console.log('max: ' + arrDoc[arrDoc.length - 1]);
arrDoc = [];
for (var property in navigator) {
    arrDoc.push(property);
}
arrDoc.sort();
console.log('navigator: ');
console.log('min: ' + arrDoc[0]);
console.log('max: ' + arrDoc[arrDoc.length - 1]);