/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    if(typeof selector !== 'string') {
      throw new Error('Not a correct selector value! ' + selector)
    }
    
    var $element = $(selector);
    if($element.length === 0) {
      throw Error();
    }
    
    $element.children('.button').text('hide');
    $element.on('click', '.button', function() {
      $this = $(this);
      
      var $topMostContent = $this.next();
      while(!$topMostContent.hasClass('content')) {
        if($topMostContent.hasClass('button')) {
          return;
        }
        
        $topMostContent = $topMostContent.next();
        //$this = $topMostContent;
      }

      if ($topMostContent.css('display') !== 'none') {
          $this.text('show');
          $topMostContent.css('display', 'none');
      } else {
          $this.text('hide');
          $topMostContent.css('display', '');
      }        
   });
   
  };
};

module.exports = solve;