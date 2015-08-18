/* Task Description */
/*
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  - * There is a set of students listed for the course
    - * Each student has firstname, lastname and an ID
    - * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  - * Create method init
    - * Accepts a string - course title
    - * Accepts an array of strings - presentation titles
    - * Throws if there is an invalid title
      - * Titles do not start or end with spaces
      - * Titles do not have consecutive spaces
      - * Titles have at least one character
    - * Throws if there are no presentations
  - * Create method addStudent which lists a student for the course
    - * Accepts a string in the format 'Firstname Lastname'
    - * Throws if any of the names are not valid
      - * Names start with an upper case letter
      - * All other symbols in the name (if any) are lowercase letters
    - * Generates a unique student ID and returns it
  - * Create method getAllStudents that returns an array of students in the format:
  -   * {firstname: 'string', lastname: 'string', id: StudentID}
  ? * Create method submitHomework
    ? * Accepts studentID and homeworkID
      ? * homeworkID 1 is for the first presentation
      ? * homeworkID 2 is for the second one
      ? * ...
    ? * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
  // validation methods
  function notValidTitle(title) {
    var i,
        len;

    if(typeof title !== 'string') {
      return true;
    }

    if(title.length === 0) {
      return true;
    }

    if(title.charCodeAt(0) === 32 || title.charCodeAt(title.length-1) === 32) {
      return true;
    }

    for(i = 1, len = title.length - 2; i <= len; i += 1) {
      if(title.charCodeAt(i) === 32 && title.charCodeAt(i + 1) === 32) {
        return true;
      }
    }

    return false;
  }

  function notValidPresentations(presentations) {
    var i,
        len;
    presentations = presentations || [];

    if(presentations.length === 0) {
      return true;
    }

    for(i = 0, len = presentations.length; i < len; i += 1) {
      if(notValidTitle(presentations[i])) {
        return true;
      }
    }

    return false;
  }

  function notValidStudentName(name) {
    var fname,
        lname,
        i,
        len;

    if(typeof name !== 'string') {
      return true;
    }

    if(name.split(' ').length > 2) {
      return true;
    }

    fname = name.split(' ')[0];
    lname = name.split(' ')[1];
    if(!(fname.charCodeAt(0) >= 65 && fname.charCodeAt(0) <= 90) ||
         !(lname.charCodeAt(0) >= 65 && lname.charCodeAt(0) <= 90)) {
            return true;
    }

    if(fname.length > 1) {
      for(i = 1, len = fname.length; i < len; i += 1) {
        if(!(fname.charCodeAt(i) >= 97 && fname.charCodeAt(i) <= 122)) {
          return true;
        }
      }
    }

    if(lname.length > 1) {
      for(i = 1, len = lname.length; i < len; i += 1) {
        if(!(lname.charCodeAt(i) >= 97 && lname.charCodeAt(i) <= 122)) {
          return true;
        }
      }
    }

    return false;
  }

  function invalidId(id) {
    if(typeof id !== 'number') {
      return true;
    }

    if(id !== parseInt(id) || id < 1) {
      return true;
    }

    return false;
  }

  function notListedStudent(result) {

  }

  function invalidStudent(results) {
    var i,
        len;

    for(i = 0, len = results.length; i < len; i += 1) {
      if(results[i].StudentID > this.students.length || results[i].StudentID < 1) {
        return true;
      }
    }

    return false;
  }

  function cheatingStudent(results) {
    var i,
        len,
        j,
        lenJ;

    for(i = 0, len = results.length; i < len; i += 1) {
      for(j = i+1, lenJ = results.length; j < lenJ; j += 1) {
        if(results[i] === results[j]) {
          return true;
        }
      }
    }

    return false;
  }

  function invalidScore(results) {
    var i,
        len;

    for(i = 0, len = results.length; i < len; i += 1) {
      if(typeof results[i].Score !== 'number') {
        return true;
      }
    }

    return false;
  }

	var Course = {
		init: function(title, presentations) {
      this.title = title;
      this.presentations = presentations;
      this.students = [];
      return this;
		},
		addStudent: function(name) {
      if(notValidStudentName(name)) {
        throw Error('Not valid student name: ' + name);
      }

      this.students.push({
        firstname: name.split(' ')[0],
        lastname: name.split(' ')[1],
        id: this.students.length + 1
      });
      return this.students.length;
		},
		getAllStudents: function() {
      return this.students.slice();
		},
		submitHomework: function(studentID, homeworkID) {
      if(invalidId(studentID) || invalidId(homeworkID)) {
        throw Error('Invalid. Student id = ' + studentID + '; Homework id = ' + homeworkID);
      }

      if(studentID > this.students.length || homeworkID > this.presentations.length) {
        throw Error('Invalid. Student id = ' + studentID + '; Homework id = ' + homeworkID);
      }


      return this;
		},
		pushExamResults: function(results) {
      /** Create method pushExamResults
        * Accepts an array of items in the format {StudentID: ..., Score: ...}
          * StudentIDs which are not listed get 0 points
        * Throw if there is an invalid StudentID
        * Throw if same StudentID is given more than once ( he tried to cheat (: )
        * Throw if Score is not a number
        * */
        if(!Array.isArray(results)) {
          throw Error;
        }

        if(typeof results === 'undefined') {
          throw Error;
        }

        if(invalidStudent(results) || cheatingStudent(results) || invalidScore(results)) {
              throw Error('Exam result say that there is invalid sutdent');
        }

        //notListedStudent(result);
		},
		getTopStudents: function() {
		},
    get title() {
      return this._title;
    },
    set title(value) {
      if(notValidTitle(value)) {
        throw Error('not valid title: ' + value);
      }
      this._title = value;
    },
    get presentations() {
      return this._presentations;
    },
    set presentations(value) {
      if(notValidPresentations(value)) {
        throw Error('not valid presentations');
      }
      this._presentations = value;
    },
    get students() {
      return this._students;
    },
    set students(value) {
      this._students = value;
    }
	};

	return Course;
}


module.exports = solve;
