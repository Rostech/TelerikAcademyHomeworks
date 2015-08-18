/*Problem 12. Generate list

Write a function that creates a HTML <ul> using a template for every HTML <li>.
The source of the list should be an array of elements.
Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.*/

var people = [
    { name: 'Sofka', age: 23 },
    { name: 'Peter', age: 14 },
    { name: 'Stamat', age: 18 }
];

var tmpl = document.getElementById('list-item').innerHTML;

var peopleList = generateList(people, tmpl)

function generateList(people, tmpl) {
    var result = '<ul>',
        i,
        tempTemplate = '',
            regName = /-\{name\}-/g,
            regAge = /-\{age\}-/g;
    for (i in people) {
        tempTemplate = tmpl;
        result += '<li>';
        tempTemplate = tempTemplate.replace(regName, people[i].name);
        tempTemplate = tempTemplate.replace(regAge, people[i].age);
        result += tempTemplate;
        result += '</li>'
    }
    result += '</ul>';
    return result;
}
console.log("The result is: " );
console.log(peopleList);