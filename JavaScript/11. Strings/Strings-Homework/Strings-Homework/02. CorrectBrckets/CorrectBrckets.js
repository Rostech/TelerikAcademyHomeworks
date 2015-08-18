/*Problem 2. Correct brackets

Write a JavaScript function to check if in a given expression the brackets are put correctly*/

var correctExpression = '((a+b)/5-d)',
    incorrectExpression = ')(a+b))';

function checkExpressionsBrackets(expression) {
    expression = expression || '';
    var i,
        len,
        countOpenningBracket = 0,
        countClosingBracket = 0;
    for (i = 0, len = expression.length; i < len; i += 1) {
        if (expression[i] === '(') {
            countOpenningBracket += 1;
        }
        if (expression[i] === ')') {
            countClosingBracket += 1;
        }
        if (countOpenningBracket < countClosingBracket) {
            return false;
        }
    }
    return true;
}

var checkingExpression = checkExpressionsBrackets(correctExpression);
console.log('Is ' + correctExpression + ' correct? => ' + checkingExpression);
checkingExpression = checkExpressionsBrackets(incorrectExpression);
console.log('Is ' + incorrectExpression + ' correct? => ' + checkingExpression);