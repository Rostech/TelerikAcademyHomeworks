/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {		
		// name validation methods
		function validNameLength(name){
			return (name.length >= 3 && name.length <= 20);
		}
		
		function validNameLetters(name){
			var i,
				len;
			for(i = 0, len = name.length; i < len; i += 1){
				if(name.charAt(i).toLowerCase() < 97 || name.charAt(i).toLowerCase() > 122){
					return false;
				}
			}
			return true;
		}
		
		// constructor function
		function Person(firstname, lastname, age) {			
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
		}
		
		// properties
		Object.defineProperty(Person.prototype, 'firstname', {
			get: function () {
				return this._firstname;
			}, 
			set: function (value) {
				// using the validation methods
				if(!validNameLetters(value) || !validNameLength(value)  ){
					throw Error('invalid first name!---' + value);
				}
				this._firstname = value;
				return this;
			}			
		});
		
		Object.defineProperty(Person.prototype, 'lastname', {
			get: function () {
				return this._lastname;
			}, 
			set: function (value) {
				// using the validation methods
				if(!validNameLength(value) || !validNameLetters(value)){
					throw Error('invalid lastname name!' + value);
				}
				this._lastname = value;
				return this;
			}			
		});
		
		Object.defineProperty(Person.prototype, 'age', {
			get: function () {
				return this._age;
			}, 
			set: function (value) {
				value = parseFloat(value);
				if(isNaN(value) || value < 0 || value > 150){
					throw Error('invalid number' + value);
				}
				this._age = value;
				return this;
			}			
		});
		
		Object.defineProperty(Person.prototype, 'fullname', {
			get: function () {
				return this._firstname + ' ' + this._lastname;
			}, 
			set: function (value) {
			    value = value.split(' ');
				this._firstname = value[0];
				this._lastname = value[1];				
				return this;
			}			
		});
				
		Person.prototype.introduce = function(){
			return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
		}
		
		return Person;
	} ());
	
	return Person;
}
module.exports = solve;