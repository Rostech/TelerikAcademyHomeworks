/*Problem 4. Average age of females

Write a function that calculates the average age of all females, extracted from an array of persons
Use Array#filter
Use only array methods and no regular loops (for, while)*/

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


function averageAgeOfAllFemales(arr) {
    arr = arr || [];
    var arrOnlyWithFemales = arr.filter(function (item) { return item.gender === 'female'; }),
        count = 0,
        len = arrOnlyWithFemales.length;
    arrOnlyWithFemales.forEach(function (item) { count += item.age; });
    return count / len;
}

console.log("The average age of all females is: " + averageAgeOfAllFemales(arr));