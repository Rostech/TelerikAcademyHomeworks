/*Task 2.

Write a function that finds all the prime numbers in a range
It should return the prime numbers in an array
It must throw an Error if any of the range params is not convertible to Number
It must throw an Error if any of the range params is missing */

function task2(fromNumber, toNumber){
	var result = [];
	
	function isPrimeNumber(number){
		if(number < 2){
			return false;
		}
		var i,
			len = Math.sqrt(number);
		for(i = 2; i <= len; i += 1){
			if(number % i === 0){
				return false;
			}
		}
		return true;
	}
	
	if(arguments.length < 2){
		throw Error;
	}
	if(parseFloat(fromNumber)  && parseFloat(toNumber)){
		fromNumber = parseFloat(fromNumber);
		toNumber = parseFloat(toNumber);
	} else {
		throw Error;
	}
	
	while(fromNumber <= toNumber){
		if(isPrimeNumber(fromNumber)){
			result[result.length] = fromNumber;
		}
		fromNumber += 1;
	}
	
	return result;
}

task2(2, 17);