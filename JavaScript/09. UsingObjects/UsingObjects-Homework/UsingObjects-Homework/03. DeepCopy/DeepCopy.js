/*Problem 3. Deep copy

Write a function that makes a deep copy of an object.
The function should work for both primitive and reference types.*/



var person = {
    fname: "Stamat",
    lname: "Levandovski",
    age: 32,
    arr: [1,2,3],
    toString:function(){
        return this.fname + " " + this.lname + ", " + this.age + " years old. " + this.arr.join(", ")+  " "
            + this.insideObj.string + " " + this.insideObj.number;
    },
    insideObj: {
        string: "inside obj",
        number: 99
    }
}

function deepCopy(obj) {
    if (obj === null || typeof (obj) !== 'object') {
        return obj;
    }
    var newObj = obj.constructor(),
        prop;
    for (prop in obj) {
        newObj[prop] = deepCopy(obj[prop]);
    }
    return newObj;
}

console.log("Person obj before changing: " + person.toString());
var copy = deepCopy(person);
console.log("Copy obj before changing: " + copy.toString());
copy.fname = "Stefka";
copy.age = 20;
copy.lname = "Ivanova";
copy.arr = [0, 0, 0];
copy.insideObj.string = "--------";
copy.insideObj.number = 0;
console.log("Person obj after changing: " + person.toString());
console.log("Copy obj after changing: " + copy.toString());