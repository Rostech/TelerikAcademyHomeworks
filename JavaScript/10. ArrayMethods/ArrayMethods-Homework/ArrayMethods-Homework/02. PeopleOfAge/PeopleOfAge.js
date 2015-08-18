/*
 Problem 2. People of age

Write a function that checks if an array of person contains only people of age (with age 18 or greater)
Use only array methods and no regular loops (for, while)
 */

var arr = [
    { firstname: "Billy", lastname: "Petrov", age: 19 },
    { firstname: "Pontii ", lastname: "Petrov", age: 26 },
    { firstname: "Sefadoki ", lastname: "Ivanov ", age: 30 },
    { firstname: "Pesho ", lastname: "Petrov", age: 10 },
    { firstname: "Ivan ", lastname: "Ivanov ", age: 12 },
    { firstname: "Bulgar", lastname: "Iliev", age: 73 },
    { firstname: "Unufri", lastname: "Stefonv", age: 43 },
    { firstname: "Pesho", lastname: "Komarov", age: 38 }
];

function allOlderThan17(arr) {
    arr = arr || [];
    return arr.every(function (age) { return !!(age.age >= 18); });
}

console.log("All people are older than or 18 years old : " + allOlderThan17(arr));