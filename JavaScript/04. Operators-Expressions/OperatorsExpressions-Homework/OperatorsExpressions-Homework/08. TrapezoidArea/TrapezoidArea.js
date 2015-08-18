    /*
     * Problem 8. Trapezoid area

    Write an expression that calculates trapezoid's area by given sides a and b and height h.
     */


    var a = [5, 2, 8.5, 100, 0.222];
    var b = [7, 1, 4.3, 200, 0.333];
    var h = [12, 33, 2.7, 300, 0.555];

    for (var i = 0; i < a.length; i += 1)
    {
        console.log("a: " + a[i] + "  b: " + b[i] + "  h: " + h[i] + "  area: " + (((a[i] + b[i]) / 2) * h[i]).toString().substring(0,9));
    }