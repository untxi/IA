####Tecnologico de Costa Rica
##Intenigencia Artificial
####MiniMax
##Samantha Arburola
##Abril 2018
##
##Reference from Code.activestate.com


import os
import copy

##Global Values
n = 8 #board size (even)
board = [['0' for x in range(n)] for y in range(n)]
#8 directions
dirx = [-1, 0, 1, -1, 1, -1, 0, 1]
diry = [-1, -1, -1, 0, 0, 1, 1, 1]


def InitBoard():
    if n % 2 == 0: #if board size is even
        z = (n - 2) / 2
        board[z][z] = '2'
        board[n - 1 - z][z] = '1'
        board[z][n - 1 - z] = '1'
        board[n - 1 - z][n - 1 - z] = '2'


def PrintBoard():
    m = len(str(n - 1))
    for y in range(n):
        row = ''
        for x in range(n):
            row += board[y][x]
            row += ' ' * m
        print row + ' ' + str(y)
    print
    row = ''
    for x in range(n):
        row += str(x).zfill(m) + ' '
    print row + '\n'


def MakeMove(pBoard, x, y, pPlayer): #assuming valid move
    totctr = 0 #total number of opponent pieces taken
    pBoard[y][x] = pPlayer
    for d in range(8): #8 directions
        ctr = 0
        for i in range(n):
            dx = x + dirx[d] * (i + 1)
            dy = y + diry[d] * (i + 1)
            if dx < 0 or dx > n - 1 or dy < 0 or dy > n - 1:
                ctr = 0
                break
            elif pBoard[dy][dx] == pPlayer:
                break
            elif pBoard[dy][dx] == '0':
                ctr = 0
                break
            else:
                ctr += 1
        for i in range(ctr):
            dx = x + dirx[d] * (i + 1)
            dy = y + diry[d] * (i + 1)
            pBoard[dy][dx] = pPlayer
        totctr += ctr
    return (pBoard, totctr)


def ValidMove(pBoard, x, y, pPlayer):
    if x < 0 or x > n - 1 or y < 0 or y > n - 1:
        return False
    if pBoard[y][x] != '0':
        return False
    (boardTemp, totctr) = MakeMove(copy.deepcopy(pBoard), x, y, pPlayer)
    if totctr == 0:
        return False
    return True


minEvalBoard = -1 #min - 1
maxEvalBoard = n * n + 4 * n + 4 + 1 #max + 1


def EvalBoard(pBoard, pPlayer):
    tot = 0
    for y in range(n):
        for x in range(n):
            if pBoard[y][x] == pPlayer:
                if (x == 0 or x == n - 1) and (y == 0 or y == n - 1):
                    tot += 4 #corner
                elif (x == 0 or x == n - 1) or (y == 0 or y == n - 1):
                    tot += 2 #side
                else:
                    tot += 1
    return tot


#if no valid move(s) possible then True
def IsTerminalNode(pBoard, pPlayer):
    for y in range(n):
        for x in range(n):
            if ValidMove(pBoard, x, y, pPlayer):
                return False
    return True


def Minimax(pBoard, pPlayer, depth, maximizingPlayer):
    if depth == 0 or IsTerminalNode(pBoard, pPlayer):
        return EvalBoard(pBoard, pPlayer)
    if maximizingPlayer:
        bestValue = minEvalBoard
        for y in range(n):
            for x in range(n):
                if ValidMove(pBoard, x, y, pPlayer):
                    (boardTemp, totctr) = MakeMove(copy.deepcopy(pBoard), x, y, pPlayer)
                    v = Minimax(boardTemp, pPlayer, depth - 1, False)
                    bestValue = max(bestValue, v)
    else: #minimizingPlayer
        bestValue = maxEvalBoard
        for y in range(n):
            for x in range(n):
                if ValidMove(pBoard, x, y, pPlayer):
                    (boardTemp, totctr) = MakeMove(copy.deepcopy(pBoard), x, y, pPlayer)
                    v = Minimax(boardTemp, pPlayer, depth - 1, True)
                    bestValue = min(bestValue, v)
    return bestValue


def BestMove(pBoard, pPlayer):
    maxPoints = 0
    mx = -1
    my = -1
    for y in range(n):
        for x in range(n):
            if ValidMove(pBoard, x, y, pPlayer):
                (boardTemp, totctr) = MakeMove(copy.deepcopy(pBoard), x, y, pPlayer)
                points = Minimax(boardTemp, pPlayer, depth, True)
                if points > maxPoints:
                    maxPoints = points
                    mx = x
                    my = y
    return (mx, my)

print '====================\n=== OTHELLO GAME ==='
print '===== MiniMax ======\n====================\n'
depth = 4
depthStr = raw_input('Select Search Depth (DEFAULT: 4): ')
if depthStr != '':
    depth = int(depth)
print '\n1: User 2: AI (Just press Enter for Exit!)'
InitBoard()
while True:
    for p in range(2):
        print PrintBoard()
        player = str(p + 1)
        print 'PLAYER: ' + player
        if IsTerminalNode(board, player):
            print 'Player cannot play! Game ended!'
            print 'Score User: ' + str(EvalBoard(board, '1'))
            print 'Score AI  : ' + str(EvalBoard(board, '2'))
            os._exit(0)
        if player == '1':#user's turn
            while True:
                xy = raw_input('X Y: ')
                if xy == '':
                    os._exit(0)
                (x, y) = xy.split()
                x = int(x)
                y = int(y)
                if ValidMove(board, x, y, player):
                    (board, totctr) = MakeMove(board, x, y, player)
                    print '# of pieces taken: ' + str(totctr)
                    break
                else:
                    print 'Invalid move! Try again!'
        else: #AI's turn
            (x, y) = BestMove(board, player)
            if not (x == -1 and y == -1):
                (board, totctr) = MakeMove(board, x, y, player)
                print 'AI played (X Y): ' + str(x) + ' ' + str(y)
                print '# of pieces taken: ' + str(totctr)
