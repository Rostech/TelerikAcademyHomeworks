/*
  Problem 1. Make person

Write a function for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders
 */

if (!Array.prototype.fill) {
    Array.prototype.fill = function (callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            this[i] = arguments[0];
        }
        return this;
    }
}

function createPersons(numberOfPersons) {
    numberOfPersons = numberOfPersons || 1;

    var arrWithPersons = [],
        firstNames = ['Pesho', 'Ivan', 'Stamat', 'Pontii', 'Sefadoki', 'Petrosiqn', 'Billy'],
        lastNames = ['Ivanov', 'Petrov', 'Unufri', 'Balgar', 'Stefonv', 'Kirqkov', 'Iliqnov', 'Peshev'],
        peopleAge = [34, 32, 45, 36, 32, 19, 10, 54, 20, 23, 28],
        peopleGender = [true, false],
        firstname = [],
        lastname = [],
        peopleage = []
    peoplegender = [];

    arrWithPersons[numberOfPersons - 1] = undefined;

    firstname = arrWithPersons.fill('')
    .map(function () { return getRandomDigit(firstNames.length); })
    .map(function (digit) { return numberToSomething(digit, firstNames);})
    
    lastname = arrWithPersons.fill('')
    .map(function () { return getRandomDigit(lastNames.length); })
    .map(function (digit) { return numberToSomething(digit, lastNames); })
    
    peopleage = arrWithPersons.fill('')
    .map(function () { return getRandomDigit(peopleAge.length); })
    .map(function (digit) { return numberToSomething(digit, peopleAge); })
    
    peoplegender = arrWithPersons.fill('')
    .map(function () { return getRandomDigit(peopleGender.length); })
    .map(function (digit) { return numberToSomething(digit, peopleGender); })

    arrWithPersons = arrWithPersons.fill('')
        .map(createPerson);

    function createPerson(item, index) {
        var person = {
            firstname: firstname[index],
            lastname: lastname[index],
            age: peopleage[index],
            gender: peoplegender[index],
            toString: function () {
                return (this.firstname + " " + this.lastname + " - " + this.age + " years old,  " + (this.gender ? " female " : " male "));
            }
        };
        return person;
    }

    return arrWithPersons;
}



function getRandomDigit(numberOfElements) {
    return (Math.random() * numberOfElements) | 0;
}

function numberToSomething(digit, something) {
    return something[digit];
}

var arr = createPersons(10),
    index;
for (index = 0; index < arr.length; index += 1) {
    console.log(arr[index].toString());
}

