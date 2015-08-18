
function solve(params) {
    var nk = params[0].split(' ').map(Number),
         s = params[1].split(' ').map(Number),
             result;
    //console.log(nk);
    //console.log(s);

    var temp = [];

    for (var i = 0; i < nk[1]; i++) {
        temp = [];
        for (var j = 0; j < nk[0]; j++) {
            // obshitq sluchai
            if (j > 0 && j < nk[0] - 1) {
                temp.push(transformNumber(s[j], j));
            } else {
                temp.push(transformNumber(s[j], j, 'endElements'));
            }
        }
        s = temp;
    }

    function transformNumber(number, index) {
        if (arguments.length == 2) {
            if (number === 0) {
                number = Math.abs(s[index - 1] - s[index + 1]);
                return number;
            } else if (number === 1) {
                number = s[index - 1] + s[index + 1];
                return number;
            } else if (number % 2 === 0) {
                number = Math.max(s[index - 1], s[index + 1]);
                return number;
            } else {
                number = Math.min(s[index - 1], s[index + 1]);
                return number;
            }
        } else {
            if (index === 0) {
                if (number === 0) {
                    number = Math.abs(s[s.length - 1] - s[index + 1]);
                    return number;
                } else if (number === 1) {
                    number = s[s.length - 1] + s[index + 1];
                    return number;
                } else if (number % 2 === 0) {
                    number = Math.max(s[s.length - 1], s[index + 1]);
                    return number;
                } else {
                    number = Math.min(s[s.length - 1], s[index + 1]);
                    return number;
                }

            } else {
                if (number === 0) {
                    number = Math.abs(s[index - 1] - s[0]);
                    return number;
                } else if (number === 1) {
                    number = s[index - 1] + s[0];
                    return number;
                } else if (number % 2 === 0) {
                    number = Math.max(s[index - 1], s[0]);
                    return number;
                } else {
                    number = Math.min(s[index - 1], s[0]);
                    return number;
                }

            }
        }
    }
    result = s.reduce(function (sum, number) {
        return sum + number;
    });
    console.log(result);
}


