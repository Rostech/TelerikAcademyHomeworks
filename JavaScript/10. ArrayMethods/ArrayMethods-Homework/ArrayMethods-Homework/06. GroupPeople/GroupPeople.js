/*Problem 6. Group people

Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
Use Array#reduce
Use only array methods and no regular loops (for, while)*/

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

var result = {};

arr.forEach(function (item) {
    result[item.firstname[0].toLowerCase()] = [];
});

var prevTime = true;

arr.reduce(function (prev, item, index, arr) {
    if (prevTime) {
        result[prev.firstname[0].toLowerCase()].push(prev);
        prevTime = false;
    }
    result[item.firstname[0].toLowerCase()].push(item);
});

console.log(result);

result['a'];
result['a'] = [];
result.a[0] = 10;
result.a.push(1, 2, 3, 4, 5);
console.log(result.a);



