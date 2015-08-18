/*
 * 6. Point in Circle

Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
 */

var pointsX = [0, -5, -4, 1.5, -4, 100, 0, 0.2, 0.9, 2];
var pointsY = [1, 0, 5, -3, -3.5, -30, 0, -0.8, -4.93, 2.655];

for (var i = 0; i < pointsX.length; i += 1)
{
    console.log("x: " + pointsX[i] + " y: " + pointsY[i] + " inside: " + 
        ((Math.pow(pointsX[i],2) + Math.pow(pointsY[i],2)) <= Math.pow(5, 2)));
}