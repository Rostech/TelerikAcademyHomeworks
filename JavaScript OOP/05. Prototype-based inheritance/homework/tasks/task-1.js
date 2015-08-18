/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * - method init() that gets the domElement type 
    * i.e. `Object.create(domElement).init('div')`
  * - property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
      * - attributes must be sorted in ascending alphabetical order by their name, not in the order they were added
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * - property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string) 
    * appends to the end of children list
  * - method addAttribute(name, value) 
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() { 
     
   function notValidString(strForValidation) {
       if(typeof strForValidation !== 'string'){
          return true;
       }
       return strForValidation === '';
   }
   
   function notOnlyLatinLettersAndDigits(strForValidation, withDashes) {
     var i,
         len,
         str = strForValidation.toLowerCase();
     
     if(arguments.length === 2 && withDashes === true) {
         for(i = 0, len = str.length; i < len; i += 1) {
           if(!((str.charCodeAt(i) >= 97 && str.charCodeAt(i) <= 122) ||
                  (str.charCodeAt(i) >= 48 && str.charCodeAt(i) <= 57) || 
                  (str.charCodeAt(i) === 45) /*|| str.charCOdeAt(i) === 32*/)) {
                   return true;
                }
         }         
     } else {
         for(i = 0, len = str.length; i < len; i += 1) {
           if(!((str.charCodeAt(i) >= 97 && str.charCodeAt(i) <= 122) ||
                  (str.charCodeAt(i) >= 48 && str.charCodeAt(i) <= 57))) {
                   return true;
                }
         }
     }  
     
     return false;
   }
   
   function parseHTML() {
     var html = '',
         arrWithSortedAttributes = [],
         i,
         len;
     
     html += '<' + this.type;// 
     if(Object.keys(this.attributes).length > 0) {
       arrWithSortedAttributes = Object.keys(this.attributes).sort();
       for(i = 0, len = arrWithSortedAttributes.length; i < len; i += 1) { 
        html += ' ' + arrWithSortedAttributes[i] + '="' + this.attributes[arrWithSortedAttributes[i]] + '"';
       }
     }
     
     html +='>';     
     if(this.children.length === 0) {
       html += this.content;
     } else {
       for(i = 0, len = this.children.length; i < len; i += 1 ) {
          if(typeof this.children[i] === typeof domElement) {
             html += this.children[i].innerHTML;
          } else {
             html += this.children[i];
          }
       }
     } 
          
     html += '</' + this.type +'>';
     
     return html;
   }
  
	 var domElement = (function () {
		var domElement = { };
    
    Object.defineProperties(domElement, {
      init : {
        value : function(type){
           this.type = type;
           this.attributes = {};
           this.children = [];
           this.content = '';
           return this;
        }
      },
      appendChild: {
        value : function(child){
          if(typeof child !== 'string' && typeof child !== typeof domElement) {
            throw Error;
          }
          
          child.parent = this;
          this._children.push(child);
          
          return this;
        }
      },
      addAttribute: {
        value : function(name, value) {
            if(notOnlyLatinLettersAndDigits(name, true) || notValidString(name)) {
                throw Error('attribute name error!' + name);
            }
            
            this.attributes[name] = value;
            
            return this;
        }
      },
      removeAttribute: {
        value : function(attribute){
          if(!this.attributes.hasOwnProperty(attribute)) {
            throw Error;
          }
          
          delete this.attributes[attribute];          
          return this;
        }
      }
    });
    
    Object.defineProperty(domElement, 'type', {
      get: function () {
        return this._type;
      },
      set: function (value) {
        if(notOnlyLatinLettersAndDigits(value) || notValidString(value)) {
            throw Error('type name error!');
        }
        
        this._type = value;        
      }
    });
    
    Object.defineProperty(domElement, 'attributes', {
      get: function () {
        return this._attributes;
      },
      set: function(value) {
        this._attributes = value;
      }
    });
    
    Object.defineProperty(domElement, 'children', {
      get: function () {
        return this._children;
      },
      set: function(value) {
        this._children = value;
      }
    });
    
    Object.defineProperty(domElement, 'parent', {
      get: function () {
        return this._parent;
      },
      set: function(value) {
        this._parent = value;
      }
    });
    
    Object.defineProperty(domElement, 'innerHTML', {
      get : function () {
        return  parseHTML.call(this);
      }
    });
    
    Object.defineProperty(domElement, 'content', {
      get : function () {
        return this._content;
      },
      set : function (value) {
        this._content = value;
      }
    });
    
		return domElement;
	} ());
	return domElement;
}

module.exports = solve;
