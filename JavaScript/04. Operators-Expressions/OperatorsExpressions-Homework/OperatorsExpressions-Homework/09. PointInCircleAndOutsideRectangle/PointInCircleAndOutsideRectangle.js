/*
 * Problem 9. Point in Circle and outside Rectangle

Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2)
 */

var x = [1, 3, 0, 4, 2, 4, 2.5, 3.5, -100];
var y = [4, 2, 1, 1, 0, 0, 1.5, 1.5, -100];

for (var i = 0; i < x.length; i += 1)
{
    if((Math.pow(x[i] - 1, 2) + Math.pow(y[i] - 1, 2)) <= Math.pow(3, 2))
    {
        if(x[i] < -1 || y[i] < -1 || y[i] > 1 )
        {
            console.log("x: " + x[i] + "  y: " + y[i] + "  inside K & outside of R: yes");
        }
        else
        {
            console.log("x: " + x[i] + "  y: " + y[i] + "  inside K & outside of R: no");
        }
    }
    else
    {
        console.log("x: " + x[i] + "  y: " + y[i] + "  inside K & outside of R: no");
    }
}