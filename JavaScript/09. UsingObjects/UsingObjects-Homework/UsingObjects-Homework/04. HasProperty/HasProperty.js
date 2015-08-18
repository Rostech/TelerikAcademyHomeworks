/*
 * Problem 4. Has property
 * Write a function that checks if a given object containts a given property.
 */

var property,
    hasProp;

function hasProperty(obj, property) {
    obj = obj || {};
    property = property || '';
    if (obj[property] === undefined) {
        return false;
    }
    return true;
}

var student = {
    name: 'Pesho',
    lastname: 'Hristov'
};

property = 'name';
hasProp = hasProperty(student, property);
console.log("'" + property + "' is property of student object: " + hasProp);
property = 'age';
hasProp = hasProperty(student, property);
console.log("'"+property + "' is property of student object: " + hasProp);