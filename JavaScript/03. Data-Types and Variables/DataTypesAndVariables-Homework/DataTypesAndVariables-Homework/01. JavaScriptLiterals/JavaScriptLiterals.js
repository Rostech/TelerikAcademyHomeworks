/*
 * Problem 1. JavaScript literals

Assign all the possible JavaScript literals to different variables.
 */
var integer = 2;
var floating = 2.57;
var string = 'pesho';
var char = 'a';
var nullVariable = null;
var array = [integer, floating, string];
var undefined;
var nan = NaN;
var bool = false;

var arrayWithAllVariables = [integer, floating, string, string, char, nullVariable, array, undefined, nan, bool];

for (var i = 0; i < arrayWithAllVariables.length; i += 1)
{
    console.log(arrayWithAllVariables[i]);
}

