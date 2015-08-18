/*
 * Problem 5. Youngest person
 * Write a function that finds the youngest person in a given array of people and prints his/hers full name.
 * Each person has properties firstname, lastname and age.
 */

var people = [
    { firstname: 'Gancho', lastname: 'Popov', age: 23 },
    { firstname: 'Stamat', lastname: 'Georgiev', age: 21 },
    { firstname: 'Pesho', lastname: 'Minkov', age: 29 },
    { firstname: 'Sibil', lastname: 'Iordanov', age: 98 }
];


function youngestPerson(people) {
    people = people || [];
    var person = people[0],
        i,
        result;
    for (i in people) {
        if (person.age > people[i].age) {
            person = people[i];
        }
    }
    if (person !== undefined) {
        result = "The youngest person is: " + person.firstname + " " + person.lastname + " (" + person.age + ")";
    } else {
        result = "PERSONS ARE MISSING!";
    }
    return result;
}

console.log(youngestPerson(people));