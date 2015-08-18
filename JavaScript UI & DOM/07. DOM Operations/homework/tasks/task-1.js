/* globals $ */

/*

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing ---
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed
*/

module.exports = function () {


    return function (element, contents) {
        var domElement,
            div,
            fragment,
            i,
            len;
        if (arguments.length < 2) {
            throw new Error;
        }

        if (typeof element === 'string') {
            domElement = document.getElementById(element);
        } else if (element instanceof HTMLElement) {
            domElement = element;
        } else {
            throw new Error;
        }

        if (domElement === null) {
            throw new Error;
        }

        div = document.createElement('div');
        fragment = document.createDocumentFragment();
        for (i = 0, len = contents.length; i < len; i += 1) {
            if (typeof contents[i] !== 'string' && typeof contents[i] !== 'number') {
                throw new Error;
            }

            div = div.cloneNode(true);
            div.innerHTML = contents[i];
            fragment.appendChild(div);
        }

        domElement.innerHTML = "";
        domElement.appendChild(fragment);
    };
};
