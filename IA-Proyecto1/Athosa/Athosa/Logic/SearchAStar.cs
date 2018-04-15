using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athosa.Logic
{
    class Tuple
    {
        private int row;
        private int col;
        Tuple before;
        public bool hasBefore;
        int estimation;
        double distance;

        void main(int pRow, int pCol)
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
        public void setBefore(Tuple pBefore)
        {
            before = pBefore;
            hasBefore = true;
        }
        public Tuple getBefore()
        {
            return before;
        }

        void setEstimation(int pEstimation)
        {
            estimation = pEstimation;
        }
        int getEstimation()
        {
            return estimation;
        }

        void setDistance(double pDistance)
        {
            distance = pDistance;
        }

        double getDistance()
        {
            return distance;
        }
    }

    class Matrix
    {
        int[,] matrix;
        void main(int n, int m)
        {
            matrix = new int[n, m];
        }
    }

    class SearchAStar
    {
        Tuple init;
        Tuple end;
        
        Matrix matrix;
        float probability;
        bool found;
        bool hasPath;
        List<Tuple> opened;
        List<Tuple> closed;
        List<Tuple> solution;
        Tuple actual;

        void main(Tuple pInit, Tuple pEnd, Matrix pMatrix, float pProbability)
        {
            init = pInit;
            end = pEnd;
            matrix = pMatrix;
            probability = pProbability;
            found = false;
            hasPath = true;
        }

        void start()
        {
            Tuple coord = new Tuple();
            coord.setRow(init.getRow());
            coord.setCol(init.getCol());
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
                List<Tuple> path = buildSolutionPath(); //devolver camino
                paintBoats(path);
            }
            else
                Console.WriteLine("No hay camino");

        }

        void modifyCoordInList(Tuple coord, List<Tuple> list)
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

        Tuple getCoordFromList(Tuple coord, List<Tuple> list)
        {
            Tuple element = new Tuple();
            element.setCol(-1);
            element.setRow(-1);

            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i].getRow() == coord.getRow()) && (list[i].getCol() == coord.getCol()))
                {
                    element.setCol(list[i].getCol());
                    element.setRow(list[i].getRow());
                    return element;
                }
                else
                {
                    return element;
                }
            }

        }

        List<Tuple> sortTuples(List<Tuple> toSort)
        {
            return toSort;
        }
        bool coordInList(Tuple coord, List<Tuple> list)
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
        int estimate(Tuple coord)
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
        
        void expandNode(Tuple coord) {
        for (int i = -1; i <= 1; i++) {
            for (int j = -1; j <= 1; j++) {
                int row = coord.getRow() + i;
                int col = coord.getCol() + j;
                Tuple actual = new Tuple(); ;
                actual.setRow(row);
                actual.setCol(col);
                //marcas
                if (matrix.inMatrixLimit(actual) && (i != 0 || j != 0) && matrix.getPossitionValue(row, col) != "block" 
            && matrix.getPossitionValue(row, col) != "bad")
                {
                    int bad = Math.random() * 100;
                    if (bad > probability ||
                        actual.getRow() == init.getRow() && actual.getCol() == init.getCol() ||
                        actual.getRow() == end.getRow() && actual.getCol() == end.getCol()) //si pirate es <= a la prob, entonces 
                        {   
                            actual.setBefore(coord);    //padre es coord
                            actual.setEstimation(estimate(actual));
                            //valor del anterior + distancia entre padre e hijo + estimación
                            if (matrix.getPossitionValue(row, col) != "allow")
                            {
                                actual.setDistance(getDistance(coord.getBefore() + actual.getDistance()));
                            }
                            else
                            {
                                actual.setDistance(getDistance(coord.getBefore()+ getDistance(coord, actual) * 2));
                            }

                        if(!coordInList(actual, opened) && !coordInList(actual, this.closed))    //Ni abierta ni cerrada
                            insertIntoOpened(actual);
                        else{
                            bool inClosed = true;
                            Tuple oldCoord = getCoordFromList(actual, closed);
                            if(!oldCoord) {  //buscamos en abierta
                                oldCoord = this.getCoordFromList(actual, opened);
                                inClosed = false;
                            }
                            if(getDistance(oldCoord.getBefore() > getDistance(actual)))
                            {
                                if(!inClosed)
                                    modifyCoordInList(actual, opened);
                                else
                                    modifyCoordInList(actual, closed);
                            }
                        }
                    }
                    else{
                        actual.paintCoordPirate();
                    }
                }
            }
        }
        opened = opened.sortTuples(); //reordenamos despues de cada expansión
    }

        double getDistance(Tuple coord1, Tuple coord2)
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
        List<Tuple> buildSolutionPath()
        {
            if (found)
            {
                solution.Clear();
                buildSolutionPathRec(closed[closed.Count - 1]);
                return solution;
            }
        }
        void buildSolutionPathRec(Tuple actual)
        {
            if (actual.hasBefore())
            {
                buildSolutionPathRec(getBefore(actual));
                solution.Add(actual);
            }
            else
            {
                this.solution.push(act);
            }

        }

        bool pathFound()
        {
            return found;
        }
        Tuple getFromOpened()
        {
            let first = this.opened[0];
            this.opened.splice(0, 1);
            return first;
        }

        void insertIntoOpened(Tuple coord)
        {
            opened.Add(coord);
        }
        void insertIntoClosed(Tuple coord)
        {
            closed.Add(coord);
        }

        string getDirection(Tuple beforeCoord, Tuple newCoord)
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
        void paintBoats(List<Tuple> path)
        {
            Tuple before;
            for (int i = 0; i < path.Count; i++)
            {
                Tuple coord = path[i];
                if (coord == path[0])
                {
                    before = coord;
                }
                if ((coord != path[0]) && (coord != path[path.Count - 1]))
                {
                    coord.paintCoordPath();
                    before = coord;
                }
            }
        }

    }
}
