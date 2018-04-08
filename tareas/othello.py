"""
Reglas
primero fichas negras
1 mov por turno
pasa turno si no tiene movs

MOV: pone ficha si
        linea recta diagonal u ortogonal del mismo color
"""


tablero = [[0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0]];

fuente  = [[0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0]];

destino = [[0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0],
           [0, 0, 0, 0, 0, 0, 0, 0]];

def heuristica(tablero, jugador):
    oponente = 'O';
    if jugador == 'O':
        oponente = 'X';
    misPuntos = puntos(tablero, jugador);
    oponentePuntos = puntos(tablero, oponente);

    return (misPuntos - oponentePuntos);


def copiaTablero(fuente, destino):
    for i in range(len(fuente)):
        for j in range(len(fuente[i])):
            destino[i][j] = fuente[i][j];


def miniMaxDecision(tablero, jugador, x, y):
    assert type(x) == int, "Entrada Incorrecta: x";
    assert type(y) == int, "Entrada Incorrecta: y";

    moveX = [0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0];

    moveY = [0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0,
           0,0,0,0,0,0,0,0,0,0];

    numeroMovimientos = 0;

    oponente = 'X';

    if jugador == 'X':
      oponente = 'O';

    getListaMovimiento(tablero, moverX, moverY, numeroMovimientos, jugador);

    if numeroMovimientos == 0:
      x = -1;
      y = -1;

    else:
      mejorValorMovimento = -99999;
      mejorX = moveX[0];
      mejorY = moveY[0];

      for i in range(numeroMovimientos):
        tableroTemporal = [0,0,0,0,0,0,0,0,0,0];

          copiaTablero(tablero, tableroTemporal);
          mover(tableroTemporal, moveX[i], moveY[i], jugador);

          valor = miniMaxValor(tableroTemporal, jugador, oponente,1);

          if valor > mejorValorMovimento:
            mejorValorMovimento = valor;
            mejorX = moveX[i];
            mejorY = moveY[i];


      x = mejorX;
      y = mejorY;


def minimaxValue(tablero, turnoOriginal, turnoActual, buscaJugada)

  if ((buscaJugada == 5) or finJuego(tablero)):
    return heuristica(tableroTemporal, turnoOriginal);

  moveX = [0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0];

  moveY = [0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0,
             0,0,0,0,0,0,0,0,0,0];

  numeroMovimientos = 0;
  oponente = 'X';

  if currentTurn == 'X':
    oponente = 'O';

  getListaMovimiento(board, moveX, moveY, numMoves, currentTurn);
if (numMoves == 0) 

return minimaxValue(board, originalTurn, opponent, buscaJugada + 1);

else

int bestMoveVal = -99999;
if (originalTurn != currentTurn)
bestMoveVal = 99999; 
// Try out every single move
for (int i = 0; i < numMoves; i++)

// Apply the move to a new board
char tempBoard[8][8];
copyBoard(board, tempBoard);
makeMove(tempBoard, moveX[i], moveY[i], currentTurn);
// Recursive call
int val = minimaxValue(tempBoard, originalTurn, opponent,
 searchPly + 1);
// Remember best move
if (originalTurn == currentTurn)

// Remember max if it's the originator's turn
if (val > bestMoveVal)
bestMoveVal = val;

else

// Remember min if it's opponent turn
if (val < bestMoveVal)
bestMoveVal = val;


return bestMoveVal;

  return -1;


        
