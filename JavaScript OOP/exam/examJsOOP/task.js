function solve(){   
    
    var item,
        book,
        media,
        catalog,
        bookCatalog,
        mediaCatalog,
        validator;
        
        if (!Array.prototype.findIndex) {
  Array.prototype.findIndex = function(predicate) {
    if (this == null) {
      throw new TypeError('Array.prototype.findIndex called on null or undefined');
    }
    if (typeof predicate !== 'function') {
      throw new TypeError('predicate must be a function');
    }
    var list = Object(this);
    var length = list.length >>> 0;
    var thisArg = arguments[1];
    var value;

    for (var i = 0; i < length; i++) {
      value = list[i];
      if (predicate.call(thisArg, value, i, list)) {
        return i;
      }
    }
    return -1;
  };
}
    
    validator = {
        nonEmptyString: function (str) {
            if(typeof str === 'undefined') {
                return false;
            }
            
            if(str === '') {
                return false;
            }
            
            return true;
        },
        notValidStringLength: function (str, min, max) {
            if(typeof str === 'undefined' ||
                typeof min === 'undefined' ||
                typeof max === 'undefined') {
                    return false;
                }
                
            if(str.length < min || str.length > max) {
                return false;
            }
            
            return true;
        },
        notContainingOnlyDigits: function (str) {
            var i,
                len;
            
            if(typeof str === 'undefined') {
                return false;
            }
            
            for(i = 0, len = str.length; i < len; i += 1) {
                if(isNaN(parseInt(str.charAt(i)))) {
                    return false;
                }
            }
            
            return true;            
        },
        notNumberGreaterThan: function (num, greaterThan) {
            if(typeof num === 'undefined') {
                return false;
            }
            
            if(typeof num !== 'number') {
                return false;
            }
            
            if(num <= greaterThan) {
                return false;
            }
            
            return true;
        },
        notANumberBetween: function(num, min, max) {
            if(typeof num === 'undefined' ||
                typeof min === 'undefined' ||
                typeof max === 'undefined') {
                    return false;
                }
                
            if(typeof num !== 'number') {
                return false;
            }
            
            if(num < min || max < num) {
                return false;
            }
            
            return true;
        }
    };
    
    item = (function() {
        var itemId = 0,
            item = Object.create({});
        
        Object.defineProperty(item, 'init', {
            value: function (description, name) {
                this._id = ++itemId;
                this.description = description;
                this.name = name;
                return this;
            }
        });
        
        Object.defineProperty(item, 'description', {
            get: function () {
                return this._description;
            },
            set: function (newDescr) {
                if(!validator.nonEmptyString(newDescr)) {
                    throw new Error('Item description error');
                }
                
                this._description = newDescr;
            }
        });
        
        Object.defineProperty(item, 'name', {
            get: function () {
                return this._name;
            },
            set: function (newName) {
                if(!validator.notValidStringLength(newName, 2, 40)) {
                    throw new Error('Item name error');
                }
                
                this._name = newName;
            }
        });
        
        return item;
    }());
    
    book = (function(parent) {
        var book = Object.create(parent);
        
        Object.defineProperty(book, 'init', {
            value: function (name, isbn, genre, description) {
                parent.init.call(this, description, name);
                this.isbn = isbn;
                this.genre = genre;
                return this;
            }
        });
        
        Object.defineProperty(book, 'isbn', {
            get: function () {
                return this._isbn;
            },
            set: function (newIsbn) {                
                if(!validator.notValidStringLength(newIsbn, 10, 10) && 
                    !validator.notValidStringLength(newIsbn, 13, 13)) {
                    throw new Error('Book isbn error not 10 or 13');
                }
                
                if(!validator.notContainingOnlyDigits(newIsbn)) {
                    throw new Error('Book isbn error not only digits')
                }
                
                this._isbn = newIsbn;
            }
        });
        
        Object.defineProperty(book, 'genre', {
            get: function () {
                return this._genre;
            },
            set: function (newGenre) { 
                if(!validator.notValidStringLength(newGenre, 2, 20)) {
                    throw new Error('Book genre error');
                }
                
                this._genre = newGenre;
            }
        });
        
        return book;
    }(item));
    
    media = (function(parent) {
        var media = Object.create(parent);
        
        Object.defineProperty(media, 'init', {
            value: function (name, rating, duration, description) {
                parent.init.call(this, description, name);
                this.duration = duration;
                this.rating = rating;
                return this;
            }
        });
        
         Object.defineProperty(media,'duration', {
            get: function () {
                return this._duration;
            }, 
            set: function (newDuration) {
                if(!validator.notNumberGreaterThan(newDuration, 0)) {
                    throw new Error('Media duration not greater than zero -> ' + newDuration);
                }
                
                this._duration = newDuration;
            }
        });
        
        Object.defineProperty(media,'rating', {
            get: function () {
                return this._rating;
            }, 
            set: function (newRating) {
                if(!validator.notANumberBetween(newRating, 1, 5)) {
                    throw new Error('Media rating error -> (rating is: ' + newRating + ' )');
                }
                
                this._rating = newRating;
            }
        });
        
        return media;
    }(item));
    
    
    catalog = (function () {    
        var currentCatalog = 0;
            catalog = Object.create({});
        
        Object.defineProperty(catalog, 'init', {
           value: function (name) {
                this._id = ++currentCatalog;
                this.name = name;
                this.items = [];
                return this;
            }
        });
        
        Object.defineProperty(catalog, 'name', {
           get: function () {
               return this._name;
           },
           set: function (newName) {
               if(!validator.notValidStringLength(newName, 2, 40)) {
                   throw new Error('Catalog name error -> ' + newName);
               }
               
               this._name = newName;
           }
        });
        
        Object.defineProperty(catalog, 'items', {
           get: function () {
               return this._items;
           } 
        });
        
        Object.defineProperty(catalog, 'add', {
            value: function() {
                if(arguments.length === 0) {
                    throw new Error('No argumens in catalog');
                }
                
                if(Array.isArray(arguments[0])) {
                    var arr = arguments[0],
                        i,
                        len;
                        
                    if(arr.length === 0) {
                        throw new Error ('arr is emntp');
                    }
                    for(i = 0, len < arr.length; i < len; i += 1) {
                        if(arr[i].description === 'undefined' || arr[i]._id === 'undefined') {
                            throw new Error('not item');
                        }
                    }
                    
                    for(i = 0, len < arr.length; i < len; i += 1) {
                        this.items.push(arr[i]);
                    }      
                                        
                } else {
                    if(arguments.length === 0) {
                        throw new Error('no args');
                    }
                    
                    var arr = arguments.slice(),
                        i,
                        len;
                      
                      for(i = 0, len < arr.length; i < len; i += 1) {
                        if(arr[i].description === 'undefined' || arr[i]._id === 'undefined') {
                            throw new Error('not item');
                        }
                    }
                    
                    for(i = 0, len < arr.length; i < len; i += 1) {
                        this.items.push(arr[i]);
                    }
                }                
            }
        });
        
        Object.defineProperty(catalog, 'find', {
            value: function (input) {
                if( typeof input === 'number') {
                    var id = input;
                    if(typeof id !== 'number'){
                        throw Error('id not a number');
                    }
                    var result = this.items.findIndex(function(item){
                        return item.id === id;
                    });
                    if(result < 0) {
                        return null;
                    } else {
                        this.items[result];
                    }
                    
                } else if(typeof input === 'object'){ 
                    
                } else {
                    throw Error;
                }
            }
        });
        
       
        
        return catalog;
    }());
    
    bookCatalog = (function (parent) {
        var bookCatalog = Object.create(parent);
        
        Object.defineProperty(bookCatalog, 'init', {
            value: function(name) {
                parent.init.call(this, name);
                return this;
            }
        });
        
        Object.defineProperty(bookCatalog, 'add', {
           value : function () {
               return parent.add.call(this);
           } 
        });
        
        Object.defineProperty(bookCatalog, 'getGenres', {
           value : function () {
               var result = [];
               var addthis = true;
               for(var i = 0; i < this.items.length; i += 1) {
                   addthis = true;
                   for(var j = 0; j < result.length; j += 1) {
                       if(result[i] === this.items[i].genere.toLowerCase()) {
                           addthis = false;
                           break;
                       }
                   }
                   if(addthis)
                     result.push(this.items[i].genre.toLowerCase());
               }
               return result;
           } 
        });
        
        return bookCatalog;
    }(catalog));
    
    mediaCatalog = (function (parent) {
        var mediaCatalog = Object.create(parent);
        
        Object.defineProperty(mediaCatalog, 'init', {
            value: function(name) {
                parent.init.call(this, name);                
                return this;
            }
        });
        
        return mediaCatalog;
    }(catalog));
    
    
             
    return {
        getBook: function (name, isbn, genre, description) {
            return Object.create(book).init(name, isbn, genre, description);
        },
        getMedia: function (name, rating, duration, description) {
            return Object.create(media).init(name, rating, duration, description);
        },
        getBookCatalog: function (name) {
            return Object.create(bookCatalog).init(name);
        },
        getMediaCatalog: function (name) {
            return Object.create(mediaCatalog).init(name);
        }
    };
}

// var module = solve();
// var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
// var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
// 
// 
// console.log(book1._id);
// console.log(book1.name);
// console.log(book1.isbn);
// console.log(book1.genre);
// console.log(book1.description);
// console.log(book2._id);
// console.log(book2.name);
// console.log(book2.isbn);
// console.log(book2.genre);
// console.log(book2.description);
// 
// var calatog = module.getBookCatalog('gancho');
// calatog.add([book1]);
