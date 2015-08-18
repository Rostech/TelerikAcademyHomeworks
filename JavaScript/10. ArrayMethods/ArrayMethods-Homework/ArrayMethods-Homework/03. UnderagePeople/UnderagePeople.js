/*
 * Problem 3. Underage people

Write a function that prints all underaged persons of an array of person
Use Array#filter and Array#forEach
Use only array methods and no regular loops (for, while)
 */

var arr = [
    { firstname: "Billy", lastname: "Petrov", age: 9 },
    { firstname: "Pontii ", lastname: "Petrov", age: 26 },
    { firstname: "Sefadoki ", lastname: "Ivanov ", age: 30 },
    { firstname: "Pesho ", lastname: "Petrov", age: 10 },
    { firstname: "Ivan ", lastname: "Ivanov ", age: 12 },
    { firstname: "Bulgar", lastname: "Iliev", age: 73 },
    { firstname: "Unufri", lastname: "Stefonv", age: 43 },
    { firstname: "Pesho", lastname: "Komarov", age: 38 }
];

var underAgedPeople = arr.filter(function (age) { return age.age < 18; });
console.log("Underaged people: ");
underAgedPeople.forEach(function (item) { return console.log(item.firstname + " " + item.lastname + " " + item.age); });