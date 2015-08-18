/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		
		function validateBook(title, author, isbn, category){		
			var i,
				len,
				equalToTenOrTherteen = true;
			if(!(title.length >= 2 && title.length <= 100) || !(category.length >= 2 && category.length <= 100 )){
				return false;
			}
			if(author === ''){
				return false;
			}
			for(i = 0, len = books.length; i < len; i += 1){
				if(title === books[i].title || isbn === books[i].isbn){
					return false;
				}
			}
			if(isbn.length != 10){
				equalToTenOrTherteen = false;
			} else {
				return true;
			}
			if(isbn.length != 13){
				equalToTenOrTherteen = false;
			} else {
				return true;
			}
			if(!equalToTenOrTherteen){
				return false;
			}
			return true;
		}
		
		function listBooks() {
			if(arguments.length > 0){			
				var i, 
					len, 
					result = [];
				for(i = 0, len = books.length; i < len; i += 1){
					if(arguments[0].category === books[i].category){
						result.push(books[i]);
					}
				}
				return result;
			} 
			return books;
		}	

		function addBook(book) {
			
		    book.author = book.author || '';
		    book.title = book.title || '';
		    book.isbn = book.isbn || '';
		    book.category = book.category || '';
			
			if(!validateBook(book.title, book.author, book.isbn, book.category)){
				throw Error;
			}
			
			book.ID = books.length + 1;
			books.push(book);
			categories[book.category] = categories.length+1;
			return book;
		}

		function listCategories() {
			var res = [],
				i;
			for (i in categories) {
				res.push(i);
			}
			categories = res;
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;