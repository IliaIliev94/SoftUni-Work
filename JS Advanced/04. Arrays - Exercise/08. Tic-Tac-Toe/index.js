function ticTacToe(data) {
    let board = [
        [false, false ,false],
        [false, false, false],
        [false, false, false]
    ];
    let players = ['X', 'O'];
    let hasWon = false;
    let playerMoves = 0;
    for(let i = 0; i < data.length && playerMoves < 9; i++) {
        let player = players[playerMoves % players.length];
        let x = Number(data[i][0]);
        let y = Number(data[i][2]);
        if(board[x][y] !== false) {
            console.log("This place is already taken. Please choose another!");
            continue;
        }
        board[x][y] = player;
        hasWon = checkRow(board, x, player)
            || checkColumn(board, y, player)
            || checkFirstDiagonal(board, player)
            || checkSecondDiagonal(board, player);

        if(hasWon) {
            console.log(`Player ${player} wins!`);
            break;
        }
        playerMoves++;
    }
    if(!hasWon) {
        console.log("The game ended! Nobody wins :(");
    }
    for(let i = 0; i < board.length; i++) {
        console.log(board[i].join("\t"));
    }
}
function checkRow(board, x, player) {
    let hasWon = true;
    for(let i = 0; i < board[x].length; i++) {
        if(board[x][i] !== player) {
            hasWon = false;
        }
    }
    return hasWon;
}

function checkColumn(board, y, player) {
    let hasWon = true;
    for(let i = 0; i < board.length; i++) {
        if(board[i][y] !== player) {
            hasWon = false;
        }
    }
    return hasWon;
}

function checkFirstDiagonal(board, player) {
    let hasWon = true;
    for(let i = 0; i < board.length; i++) {
        if(board[i][i] !== player) {
            hasWon = false;
        }
    }
    return hasWon;
}

function checkSecondDiagonal(board, player) {
    let hasWon = true;
    for(let i = board.length - 1, j = 0; i >= 0; i--, j++) {
        if(board[j][i] !== player) {
            hasWon = false;
        }
    }
    return hasWon;
}

ticTacToe(['0 2',
'0 0',
'1 1',
'1 0',
'2 0',
'1 1',
'1 2',
'2 2',
'2 1',
'0 0']);