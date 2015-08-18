/*
 * Problem 3. Rectangle area

Write an expression that calculates rectangle’s area by given width and height.
 */
var arrWidth = [3, 2.5, 5];
var arrHeigh = [4, 3, 5];

for (var i = 0; i < arrWidth.length; i += 1)
{
    console.log("Width: " + arrWidth[i] + " Height: " + arrHeigh[i] + "     Area: " + (arrWidth[i] * arrHeigh[i]));
}