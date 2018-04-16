using System;
using System.Collections.Generic;
using System.Linq;

namespace Athosa.Logic
{

    class MyTuple
    {
        private int row;
        private int col;
        MyTuple before;
        public bool hasBefore;
        int estimation;
        double distance;

        public MyTuple(int pRow, int pCol)
        {
            row = pRow;
            col = pCol;
        }


        public int getRow()
        {
            return row;
        }
        public int getCol()
        {
            return col;
        }
        public void setRow(int pRow)
        {
            row = pRow;
        }
        public void setCol(int pCol)
        {
            col = pCol;
        }
        public void setBefore(MyTuple pBefore)
        {
            before = pBefore;
            hasBefore = true;
        }
        public MyTuple getBefore()
        {
            return before;
        }

        public void setEstimation(int pEstimation)
        {
            estimation = pEstimation;
        }
        public int getEstimation()
        {
            return estimation;
        }

        public void setDistance(double pDistance)
        {
            distance = pDistance;
        }

        public double getDistance()
        {
            return distance;
        }
    }


    class MyMatrix
    {
        string[,] matrix;
        int n;
        int m;
        public MyMatrix(int pN, int pM)
        {
            n = pN;
            m = pM;
            matrix = new string[n, m];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = "";
                }
            }
        }

        public String getPossitionValue(int row, int col)
        {
            return matrix[row, col];
        }

        public bool inMatrixLimit(MyTuple pCoord)
        {
            return (pCoord.getRow() < n && pCoord.getCol() < m);
        }

        public void setValue(int row, int col, string value)
        {
            matrix[row, col] = value;
        }
    }



    class SearchAStar
    {
        MyTuple init;
        MyTuple end;
        MyMatrix matrix;
        double probability;
        bool found;
        bool hasPath;
        List<MyTuple> opened;
        List<MyTuple> closed;
        List<MyTuple> solution;
        MyTuple actual;

        public void main(MyTuple pInit, MyTuple pEnd, int n, int m, double pProbability)
        {
            init = pInit;
            end = pEnd;
            matrix = new MyMatrix (n, m);
            probability = pProbability;
            found = false;
            hasPath = true;
        }

        public List<MyTuple> getSolution()
        {
            return solution;
        }

        MyMatrix getMatrix()
        {
            return matrix;
        }
        void start()
        {
            MyTuple coord = new MyTuple(init.getRow(), init.getCol());
            coord.setEstimation(init.getEstimation());
            insertIntoOpened(coord);    //Insertamos el inicio en abierta

            
            while (!found && hasPath)
            {
                actual = getFromOpened();  //obtenemos el menor valor de abierta
                insertIntoClosed(actual);
                if (actual.getRow() == end.getRow() && actual.getCol() == end.getCol())  //es solucion
                    this.found = true;
                else
                {  //caso base, final
                    this.expandNode(actual);
                    if (opened.Count == 0 && !found)
                        hasPath = false;
                }

            }
            if (found)
            {
                List<MyTuple> path = buildSolutionPath(); //devolver camino
                paintBoats(path);
            }
            else
                Console.WriteLine("No hay camino");

        }

        void modifyCoordInList(MyTuple coord, List<MyTuple> list)
        {
            bool found = false;
            int i = 0;
            while (!found && i < list.Count)
            {
                if (list[i].getRow() == coord.getRow() && list[i].getCol() == coord.getCol())
                {
                    found = true;
                    list[i] = coord;
                }
                i++;
            }

        }

        MyTuple getCoordFromList(MyTuple coord, List<MyTuple> list)
        {
            MyTuple element = new MyTuple(-1,-1);

            for (int i = 0; i < list.Count(); i++)
            {
                if ((list[i].getRow() == coord.getRow()) && (list[i].getCol() == coord.getCol()))
                {
                    element.setCol(list[i].getCol());
                    element.setRow(list[i].getRow());
                    return element;
                }
            }
            return element;
            
        }

        List<MyTuple> sortMyTuples(List<MyTuple> toSort)
        {
            toSort.Sort();
            return toSort;
        }
        bool coordInList(MyTuple coord, List<MyTuple> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i].getRow() == coord.getRow()) && (list[i].getCol() == coord.getCol()))
                {
                    return true;
                }
            }
            return false;
        }
        int estimate(MyTuple coord)
        {
            int estRow = coord.getRow();
            int estCol = coord.getCol();

            if (estRow == end.getRow() && estCol == end.getCol())
            {
                return 0;
            }

            if (estRow == end.getRow())
            {
                return Math.Abs(estCol - end.getCol());
            }

            if (estCol == end.getCol())
            {
                return Math.Abs(estRow - end.getRow());
            }

            else
            {
                int dRow = Math.Abs(estRow - end.getRow());
                int dCol = Math.Abs(estCol - end.getCol());
                return Convert.ToInt32(Math.Sqrt(dRow + dCol));
            }
        }
        
        void expandNode(MyTuple coord) {
        for (int i = -1; i <= 1; i++) {
            for (int j = -1; j <= 1; j++) {
                int row = coord.getRow() + i;
                int col = coord.getCol() + j;
                MyTuple actual = new MyTuple(row, col);
                //marcas
                if (matrix.inMatrixLimit(actual) && (i != 0 || j != 0) && matrix.getPossitionValue(row, col) != "block" 
            && matrix.getPossitionValue(row, col) != "bad")
                {
                    Random myRandom = new Random();
                    int bad = myRandom.Next() * 200;
                        if (bad > probability ||
                        actual.getRow() == init.getRow() && actual.getCol() == init.getCol() ||
                        actual.getRow() == end.getRow() && actual.getCol() == end.getCol()) //si pirate es <= a la prob, entonces 
                        {   
                            actual.setBefore(coord);    //padre es coord
                            actual.setEstimation(estimate(actual));
                            //valor del anterior + distancia entre padre e hijo + estimación
                            if (matrix.getPossitionValue(row, col) != "allow")
                            {
                                actual.setDistance(getDistance(coord.getBefore(), actual));
                            }
                            else
                            {
                                double temp = getDistance(coord.getBefore(), actual);
                                actual.setDistance(temp * 2);
                            }

                        if(!coordInList(actual, opened) && !coordInList(actual, this.closed))    //Ni abierta ni cerrada
                            insertIntoOpened(actual);
                        else{
                            bool inClosed = true;
                                MyTuple oldCoord;
                                oldCoord = getCoordFromList(actual, closed);
                            if(oldCoord.getRow() == -1 && oldCoord.getCol() == -1)
                           {  //buscamos en abierta
                                oldCoord = getCoordFromList(actual, opened);
                                inClosed = false;
                            }
                            if(oldCoord.getDistance() > actual.getDistance())
                            {
                                if(!inClosed)
                                    modifyCoordInList(actual, opened);
                                else
                                    modifyCoordInList(actual, closed);
                            }
                        }
                    }
                    else{
                        paintCoordBad(actual);
                    }
                }
            }
        }
        opened = sortMyTuples(opened); //reordenamos despues de cada expansión
    }

        double getDistance(MyTuple coord1, MyTuple coord2)
        {
            int row = coord1.getRow();
            int col = coord1.getCol();
            if (row == coord2.getRow() && col == coord2.getCol())
            {
                return 0;                
            }
            if (row == coord2.getRow())
            {
                return Math.Abs(col - coord2.getCol());
            }
            if (col == coord2.getCol())
            {
                return Math.Abs(row - coord2.getRow());
            }
            else
            {
                int dRow = Math.Abs(row - coord2.getRow());
                int dCol = Math.Abs(col - coord2.getCol());
                return Math.Sqrt(Math.Pow(dRow, 2) + Math.Pow(dCol, 2));
            }
        }
        List<MyTuple> buildSolutionPath()
        {
            if (found)
            {
                solution.Clear();
                buildSolutionPathRec(closed[closed.Count() - 1]);
            }
            return solution;
        }
        void buildSolutionPathRec(MyTuple actual)
        {
            if (actual.hasBefore)
            {
                buildSolutionPathRec(actual.getBefore());
                solution.Add(actual);
            }
            else
            {
                solution.Add(actual);
            }

        }

        bool pathFound()
        {
            return found;
        }
        MyTuple getFromOpened()
        {
            MyTuple first = opened[0];
            return first;
        }

        void insertIntoOpened(MyTuple coord)
        {
            opened.Add(coord);
        }
        void insertIntoClosed(MyTuple coord)
        {
            closed.Add(coord);
        }

        string getDirection(MyTuple beforeCoord, MyTuple newCoord)
        {
            if (beforeCoord.getCol() == newCoord.getCol())
            {
                if (beforeCoord.getRow() == newCoord.getRow() + 1)
                {
                    return "up";
                }
                else
                {
                    return "down";
                }
            }

            if (beforeCoord.getRow() == newCoord.getRow())
            {
                if (beforeCoord.getCol() == newCoord.getCol() + 1)
                {
                    return "right";
                }
                else
                {
                    return "left";
                }
            }
            else
            {
                if (beforeCoord.getRow() == newCoord.getRow() + 1)
                {
                    return "up";
                }
                else
                {
                    return "down";
                }
            }
        }
        void paintBoats(List<MyTuple> path)
        {
            MyTuple before;
            for (int i = 0; i < path.Count; i++)
            {
                MyTuple coord = path[i];
                if (coord == path[0])
                {
                    before = coord;
                }
                if ((coord != path[0]) && (coord != path[path.Count - 1]))
                {
                    paintCoordPath(coord);
                    before = coord;
                }
            }
        }

        void paintCoordBad(MyTuple pMyTuple)
        {

            matrix.setValue(pMyTuple.getRow(), pMyTuple.getCol(), "bad");
        }

        void paintCoordPath(MyTuple pMyTuple)
        {
            matrix.setValue(pMyTuple.getRow(), pMyTuple.getCol(), "allow");
        }
    }

}
