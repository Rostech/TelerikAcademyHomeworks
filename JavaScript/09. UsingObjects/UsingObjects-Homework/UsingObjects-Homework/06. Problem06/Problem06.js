/*
 * Problem 6.

Write a function that groups an array of people by age, first or last name.
The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
Use function overloading (i.e. just one function)
 */


var people = [
    { firstname: 'Gancho', lastname: 'Popov', age: 23 },
    { firstname: 'Stamat', lastname: 'Georgiev', age: 21 },
    { firstname: 'Pesho', lastname: 'Minkov', age: 29 },
    { firstname: 'Sibil', lastname: 'Iordanov', age: 98 }
];

function group(people, prop) {
    var i,
        newArr = {},
        arrToAdd = [];
    for (i in people) {
        arrToAdd.push(people[i][prop]);
    }
    newArr[prop] = arrToAdd;
    return newArr;
}

group(people, 'firstname');
var groupedByFname = group(people, 'firstname');
var groupedByLname = group(people, 'lastname');
var groupedByAge = group(people, 'age');

console.log("Grouped by firstname: " + groupedByFname.firstname);
console.log("Grouped by lastname: " + groupedByLname.lastname);
console.log("Grouped by age: " + groupedByAge.age);