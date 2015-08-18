/*
 * Problem 1. Planar coordinates

Write functions for working with shapes in standard Planar coordinate system.
Points are represented by coordinates P(X, Y)
Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
Calculate the distance between two points.
Check if three segment lines can form a triangle.
 */
var pointOne = new Point(9, 7),
     pointTwo = new Point(3, 2),
     lineOne = new Line(new Point(5, 6), new Point(3, 4)),
     lineTwo = new Line(new Point(7, 2), new Point(8, 1)),
     lineThree = new Line(new Point(7, 4), new Point(7, 7));
    

function Point(x, y) {
    this.x = x;
    this.y = y;
}

function Line(point1, point2) {
    this.begining = point1;
    this.end = point2;
}


function distance(point1, point2) {
    return Math.sqrt(Math.pow(point1.x - point2.x, 2) + Math.pow(point1.y - point2.y, 2));
}

function checkIfCanFormATriangle(line1, line2, line3) {
    if(distance(lineOne.begining, lineOne.end) + distance(lineTwo.begining, lineTwo.end) > distance(lineThree.begining, lineThree.end)
        && distance(lineThree.begining, lineThree.end) + distance(lineTwo.begining, lineTwo.end) > distance(lineOne.begining, lineOne.end)
        && distance(lineOne.begining, lineOne.end) + distance(lineThree.begining, lineThree.end) > distance(lineTwo.begining, lineTwo.end)) {
        return true;
    } else {
        return false;
    }
}

console.log("Distance between (" + pointOne.x + ", " + pointOne.y + ") and (" + pointTwo.x + ", " + pointTwo.y + ") = " + distance(pointOne, pointTwo));
console.log("L(" + "P(" + lineOne.begining.x + ", " + lineOne.begining.y + ") P("  + lineOne.end.x + ", " + lineOne.end.y + ") and " + 
            "L(" + "P(" + lineTwo.begining.x + ", " + lineTwo.begining.y + ") P("  + lineTwo.end.x + ", " + lineTwo.end.y + ") and " + 
            "L(" + "P(" + lineThree.begining.x + ", " + lineThree.begining.y + ") P("  + lineThree.end.x + ", " + lineThree.end.y + ") ->  " + 
            (checkIfCanFormATriangle(lineOne, lineTwo, lineThree) ? " Can make a triangle! " : "Can not mke a triangle!")
    );

