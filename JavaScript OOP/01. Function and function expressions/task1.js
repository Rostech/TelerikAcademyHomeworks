/*
Task 1.

Write a function that sums an array of numbers:
Numbers must be always of type Number
Returns null if the array is empty
Throws Error if the parameter is not passed (undefined)
Throws if any of the elements is not convertible to Number
*/

function task1(arr){
	arr = arr || [];
	var result;
	if(arguments.length < 1){
		throw Error;
	}
	if(arr.length == 0){
		return null;
	}	
    result = arr.reduce(function(sum, number) { 
		if(parseFloat(number)){
			number = parseFloat(number);
		} else {
			throw Error;
		}
		return sum + number;}, 0);
	return result;
}