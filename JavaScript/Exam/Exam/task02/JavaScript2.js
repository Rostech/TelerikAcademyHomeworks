function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]), i, move;
    var field = [];
    for (var f = 0; f < rows; f++) {
        field.push(params[2 + f]);
    }

    var moveFrom, moveTo;

    for (i = 0; i < tests; i++) {
        move = params[rows + 3 + i];
        //console.log(move);
        move = move.split(' ').filter(function (word) { return !!word });
        moveFrom = move[0];
        moveTo = move[1];

        if (canWeMove(moveFrom, moveTo)) {
            console.log('yes');
            //console.log(moveFrom +"->"+ moveTo + 'yes'); // or console.log('no');

        } else {
            //console.log(moveFrom + "->" + moveTo + 'no');
            console.log('no');
        }


        // Your solution here

    }

    function canWeMove(moveFrom, moveTo) {
        var rowF, rowT, colF, colT;
        rowF = Math.abs(rows - moveFrom[1]);
        colF = (moveFrom.charCodeAt(0) - 97);
        rowT = moveTo[1];
        rowT = Math.abs(rows - moveTo[1]);
        colT = (moveTo.charCodeAt(0) - 97);

        var moveElement = field[rowF][colF];
        var moveToElement = field[rowT][colT];


        //console.log('moveElement -> ' + moveElement);

        if (rowF == rowT && colF == colT) {
            return false;
        }

        if (moveElement === '-') {
            return false;
        } else {

            if (moveToElement === 'R' || moveToElement === 'B' || moveToElement === 'Q') {
                return false;
            }

            if (moveElement === 'R') {



                if (rowF != rowT && colF != colT) {
                    return false;
                }

                if (rowF != rowT) { // moving rows

                    if (rowF >= rowT) { // move left

                        for (var j = rowF - 1; j >= rowT; j--) {
                            if (field[j][colT] != '-') {
                                return false;
                            }
                        }
                        return true;

                    } else { // move right
                        for (var j = rowF + 1; j <= rowT; j++) {
                            if (field[j][colT] != '-') {
                                return false;
                            }
                        }
                        return true;
                    }

                } else if (colF != colT) { // moving cols

                    if (colF >= colT) { // move left

                        for (var j = colF - 1; j >= colT; j--) {
                            if (field[rowT][j] != '-') {
                                return false;
                            }
                        }
                        return true;

                    } else { // move right
                        for (var j = colF + 1; j <= colT; j++) {
                            if (field[rowT][j] != '-') {
                                return false;
                            }
                        }
                        return true;
                    }

                }

            } else if (moveElement === 'Q') {

                

                if (rowF == rowT && colF != colF) { // move left right
                    if (colF >= colT) { // move left

                        var jCol;
                        jRow = rowF;
                        jCol = colF - 1;
                        while (jCol != colT) {
                            if (field[jRow][jCol] != '-') {
                                return false;
                            }
                            jRow;
                            jCol--;
                        }
                        return true;
                    } else { // move right

                        var jCol;
                        jRow = rowF;
                        jCol = colF + 1;
                        while (jCol != colT) {
                            if (field[jRow][jCol] != '-') {
                                return false;
                            }
                            jRow;
                            jCol++;
                        }
                        return true;

                    }
                }
                if (rowF != rowT && colF == colT) { // move top down
                    if (rowF >= rowT) { // move up
                        var jCol;
                        jRow = rowF - 1;
                        jCol = colF;
                        while (jRow != rowT) {
                            if (field[jRow][jCol] != '-') {
                                return false;
                            }
                            jRow--;
                            jCol;
                        }
                        return true;
                    } else { // move down

                        var jCol;
                        jRow = rowF + 1;
                        jCol = colF;
                        while (jRow != rowT) {
                            if (field[jRow][jCol] != '-') {
                                return false;
                            }
                            jRow++;
                            jCol;
                        }
                        return true;

                    }
                }

                if ((rowF >= rowT && colF >= colT) || (rowF > rowT && colF < colT)
                    || (rowF < rowT && colF > colT) || (rowF < rowT && colF < colT)) {
                    if (Math.abs(rowF - rowT) != Math.abs(colF - colT)) {
                        return false;
                    }
                }

                if (rowF >= rowT && colF >= colT) {// if > or >= // move up left{
                    var jRow, jCol;
                    jRow = rowF - 1;
                    jCol = colF - 1;
                    while (jRow != rowT && jCol != colT) {
                        if (field[jRow][jCol] != '-') {
                            return false;
                        }
                        jRow--;
                        jCol--;
                    }
                    return true;

                } else if (rowF > rowT && colF < colT) { // move up right
                    var jRow, jCol;
                    jRow = rowF - 1;
                    jCol = colF + 1;
                    while (jRow != rowT && jCol != colT) {
                        if (field[jRow][jCol] != '-') {
                            return false;
                        }
                        jRow--;
                        jCol++;
                    }
                    return true;

                } else if (rowF < rowT && colF > colT) { // move down left
                    var jRow, jCol;
                    jRow = rowF + 1;
                    jCol = colF - 1;
                    while (jRow != rowT && jCol != colT) {
                        if (field[jRow][jCol] != '-') {
                            return false;
                        }
                        jRow++;
                        jCol--;
                    }
                    return true;

                } else if (rowF < rowT && colF < colT) { // move down right
                    var jRow, jCol;
                    jRow = rowF + 1;
                    jCol = colF + 1;
                    while (jRow != rowT && jCol != colT) {
                        if (field[jRow][jCol] != '-') {
                            return false;
                        }
                        jRow++;
                        jCol++;
                    }
                    return true;
                }

            } else { // moveElement === B
                if (rowF == rowT || colF == colT) {
                    return false;
                }



                //if ((rowF >= rowT && colF >= colT) || (rowF > rowT && colF < colT)
                 //   || (rowF < rowT && colF > colT) || (rowF < rowT && colF < colT)) {
                    if (Math.abs(rowF - rowT) != Math.abs(colF - colT)) {
                        return false;
                    }
                //}

                if (rowF >= rowT && colF >= colT) {// if > or >= // move up left{
                    var jRow, jCol;
                    jRow = rowF - 1;
                    jCol = colF - 1;
                    while (jRow != rowT && jCol != colT) {
                        if (field[jRow][jCol] != '-') {
                            return false;
                        }
                        jRow--;
                        jCol--;
                    }
                    return true;

                } else if (rowF > rowT && colF < colT) { // move up right
                    var jRow, jCol;
                    jRow = rowF - 1;
                    jCol = colF + 1;
                    while (jRow != rowT && jCol != colT) {
                        if (field[jRow][jCol] != '-') {
                            return false;
                        }
                        jRow--;
                        jCol++;
                    }
                    return true;

                } else if (rowF < rowT && colF > colT) { // move down left
                    var jRow, jCol;
                    jRow = rowF + 1;
                    jCol = colF - 1;
                    while (jRow != rowT && jCol != colT) {
                        if (field[jRow][jCol] != '-') {
                            return false;
                        }
                        jRow++;
                        jCol--;
                    }
                    return true;

                } else if (rowF < rowT && colF < colT) { // move down right
                    var jRow, jCol;
                    jRow = rowF + 1;
                    jCol = colF + 1;
                    while (jRow != rowT && jCol != colT) {
                        if (field[jRow][jCol] != '-') {
                            return false;
                        }
                        jRow++;
                        jCol++;
                    }
                    return true;
                }
            }
        }
        return true;
    }
}



solve(['3',
 '4',
 'RRR-',
 'RQR-',
 'RRR-',
 '12',
 'b2 b2',
 'b2 b3',
 'b2 b1',
 'b2 c3',
 'b2 a3',
 'b2 a2',
 'b2 a1',
 'b2 c1',
 'b2 c2',
 'b2 b1',
 'b2 a3',
 'b2 d3']);








