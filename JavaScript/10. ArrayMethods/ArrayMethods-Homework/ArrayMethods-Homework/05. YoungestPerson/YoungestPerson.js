/*Problem 5. Youngest person

Write a function that finds the youngest male person in a given array of people and prints his full name
Use only array methods and no regular loops (for, while)
Use Array#find*/

if(!Array.prototype.find){
    Array.prototype.find = function(callback){
        var i, len = this.length;
        for(i = 0; i < len; i += 1){
            if(callback(this[i], i, this)){
                return this[i];
            }
        }
    }
}

var arr = [
    { firstname: "Billy", lastname: "Petrov", age: 9, gender: 'female' },
    { firstname: "Pontii ", lastname: "Petrov", age: 26, gender: 'male' },
    { firstname: "Sefadoki ", lastname: "Ivanov ", age: 30, gender: 'female' },
    { firstname: "Pesho ", lastname: "Petrov", age: 10, gender: 'male' },
    { firstname: "Ivan ", lastname: "Ivanov ", age: 12, gender: 'male' },
    { firstname: "Bulgar", lastname: "Iliev", age: 73, gender: 'female' },
    { firstname: "Unufri", lastname: "Stefonv", age: 43, gender: 'male' },
    { firstname: "Pesho", lastname: "Komarov", age: 38, gender: 'female' }
];

function theYoungestMalePerson(arr) {

    arr = arr.filter(function (item) {
        return item.gender === 'male';
    });

    var youngestAge = arr[0].age;

    arr.forEach(function (item) {
        if (item.age < youngestAge) {
            youngestAge = item.age;
        }
    });

    var youngestPerson = arr.find(function (item) {
        return item.age === youngestAge;
    });

    return youngestPerson;
}
var theYoungestHuman = theYoungestMalePerson(arr);

console.log("The youngest male is : " + theYoungestHuman.firstname + " " + theYoungestHuman.lastname + " (" + theYoungestHuman.age + " years old)");
