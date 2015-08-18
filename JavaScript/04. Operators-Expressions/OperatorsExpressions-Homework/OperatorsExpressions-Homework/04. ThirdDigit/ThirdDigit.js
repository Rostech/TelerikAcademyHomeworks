/*Problem 4. Third digit
Write an expression that checks for given integer if its third digit (right-to-left) is 7.
*/

var numbers = [5, 701, 1732, 9703, 877, 777877, 9999799];
for (var i = 0; i < numbers.length; i += 1)
{
    console.log(numbers[i] + ": Third digit 7 -> " + (parseInt((numbers[i] / 100) % 10)==7 ? "true":"false"));
}