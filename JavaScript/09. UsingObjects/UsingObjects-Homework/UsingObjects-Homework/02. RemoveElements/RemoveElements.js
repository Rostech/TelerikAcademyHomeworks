/*Problem 2. Remove elements

Write a function that removes all elements with a given value.
Attach it to the array type.
Read about prototype and how to attach methods.*/

Array.prototype.remove = function (element) {
    var i,
        len;
    for (i = 0, len = this.length; i < len; i += 1) {
        if(this[i] === element){
            this.splice(i, 1);
            i -= 1;
        }
    }
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
console.log(arr.join(', '));
arr.remove(1);
console.log(arr.join(', '));
