/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  
-  If an id is provided, select the element
-   Finds all elements with class button or content within the provided element
    -   Change the content of all .button elements with "hide"
-   When a .button is clicked:
    -   Find the topmost .content element, that is before another .button and:
        -   If the .content is visible:
            -   Hide the .content
            -   Change the content of the .button to "show"
        -   If the .content is hidden:
            -   Show the .content
            -   Change the content of the .button to "hide"
        -   If there isn't a .content element after the clicked .button and before other .button, do nothing
-   Throws if:
    -   The provided DOM element is non-existant
    -   The id is either not a string or does not select any DOM element
*/

function solve(){
    return function (selector) {
        if (arguments.length === 0) {
            throw new Error;
        }

        var element,
            buttonElements,
            contentElements,
            i,
            len;
        if (typeof selector === 'string') {
            element = document.getElementById(selector);
            if (element === null) {
                throw new Error;
            }
        } else if (selector instanceof HTMLElement) {
            element = selector;
        } else {
            throw new Error;
        }

        buttonElements = element.getElementsByClassName('button');
        for (i = 0, len = buttonElements.length; i < len; i += 1) {
            buttonElements[i].innerHTML = 'hide';
        }

        element.addEventListener("click", function (e) {
            var targetBtn = e.target;
            while (targetBtn.nextElementSibling.className !== 'content') {
                if (targetBtn.nextElementSibling.className === 'button') {
                    return;
                }
                targetBtn = targetBtn.nextElementSibling;
            }

            if (e.target.innerHTML === 'hide') {
                e.target.innerHTML = 'show';
                targetBtn.nextElementSibling.style.display = 'none';
            } else {
                e.target.innerHTML = 'hide';
                targetBtn.nextElementSibling.style.display = '';
            }
        }, false);
  };
};

module.exports = solve;