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

        void main (int pRow, int pCol)
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
    }



    class SearchAStar
    {
        Tuple init;
        Tuple end;
        List<List<int>> matrix;
        float probability;
        bool found;
        bool hasPath;
        List<Tuple> opened;
        List<Tuple> closed;

        void main(Tuple pInit, Tuple pEnd,List<List<int>> pMatrix, float pProbability)
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
            insertIntoOpened(new Coord(init.getRow(), init.getCol(), estimate(init)));    //Insertamos el inicio en abierta

            Tuple actual;
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
                List<string> path = buildSolutionPath(); //devolver camino
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
                    element.setCol(list[i].getCol);
                    element.setRow(list[i].getRow);
                    return element;
                }
                else
                {
                    return element;
                }
            }
            
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
    
            /*
        int compareFunction(a, b)
        {
            if (a.getEstimation() == 0)
            {
                return -1;
            }
                
            if (b.getEstimation() == 0)
            {
                return 1;
            }
            
             if (a.getEstimation() + a.getDistFromOrigin() < b.getEstimation() + b.getDistFromOrigin())
            {
                return -1;
            }
            
            if (a.getEstimation() + a.getDistFromOrigin() == b.getEstimation() + b.getDistFromOrigin())
            {
                return 0;
            }
                
            else
            {
                return 1;
            }
        }*/

        int estimate (Tuple coord)
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
            //metodos por hacer
            /*
             expandNode(coord) {
            for (let i = -1; i <= 1; i++) {
                for (let j = -1; j <= 1; j++) {
                    let row = coord.getRow() + i;
                    let col = coord.getCol() + j;
                    let actual = new Coord(row, col);
                    //Necesitamos una especie de marcaje
                    if (this.matrix.inMatrixLimit(actual) && (i !== 0 || j !== 0) && this.matrix.getPossitionValue(row, col) !== "block" 
                && this.matrix.getPossitionValue(row, col) !== "pirate") {
                        let pirate = Math.random() * 100;
                        if (pirate > this.prob ||
                            actual.getRow() === this.init.getRow() && actual.getCol() === this.init.getCol() ||
                            actual.getRow() === this.end.getRow() && actual.getCol() === this.end.getCol()) {   //si pirate es <= a la prob, entonces 
                            actual.setBefore(coord);    //padre es coord
                            actual.setEstimation(this.estimate(actual));
                            //valor del anterior + distancia entre padre e hijo + estimación
                            if(this.matrix.getPossitionValue(row, col) !== "wind")
                                actual.setDistFromOrigin(coord.getDistFromOrigin() + this.getDistance(coord, actual));
                            else
                                actual.setDistFromOrigin(coord.getDistFromOrigin() + this.getDistance(coord, actual) * 2);
                            if(!this.coordInList(actual, this.opened) && !this.coordInList(actual, this.closed))    //Ni abierta ni cerrada
                                this.insertIntoOpened(actual);
                            else{
                                let inClosed = true;
                                let oldCoord = this.getCoordFromList(actual, this.closed);
                                if(!oldCoord) {  //buscamos en abierta
                                    oldCoord = this.getCoordFromList(actual, this.opened);
                                    inClosed = false;
                                }
                                if(oldCoord.getDistFromOrigin() > actual.getDistFromOrigin()){
                                    if(!inClosed)
                                        this.modifyCoordInList(actual, this.opened);
                                    else
                                        this.modifyCoordInList(actual, this.closed);
                                }
                            }
                        }
                        else{
                            actual.paintCoordPirate();
                        }

                        //this.insertIntoOpened(actual);
                    }
                }
            }
            this.opened = this.opened.sort(this.compareFunction); //reordenamos despues de cada expansión
        }

        getDistance(coord1, coord2) {
            let row = coord1.getRow();
            let col = coord1.getCol();
            if (row == coord2.getRow() && col == coord2.getCol())
                return 0;
            else if (row === coord2.getRow())
                return Math.abs(col - coord2.getCol());
            else if (col === coord2.getCol())
                return Math.abs(row - coord2.getRow());
            else {
                let dRow = Math.abs(row - coord2.getRow());
                let dCol = Math.abs(col - coord2.getCol());
                return Math.sqrt(Math.pow(dRow, 2) + Math.pow(dCol, 2));
            }
        }



        List<string> buildSolutionPath() {
            if (this.found) {
                this.solution = [];
                this.buildSolutionPathRec(this.closed[this.closed.Count - 1]);
                return this.solution;
            }
        }

        buildSolutionPathRec(act) {
            if (act.before) {
                this.buildSolutionPathRec(act.before);
                this.solution.push(act);
            }
            else {
                this.solution.push(act);
            }

        }

        pathFound() {
            return this.found;
        }

        getFromOpened() {
            let first = this.opened[0];
            this.opened.splice(0, 1);
            return first;
        }

        insertIntoOpened(coord) {
            this.opened.push(coord);
        }

        insertIntoClosed(coord) {
            this.closed.push(coord);
        }





        getDirection(beforeCoord, newCoord) {
            if (beforeCoord.getCol() === newCoord.getCol()) {
                if (beforeCoord.getRow() === newCoord.getRow() + 1)
                    return "up";
                else
                    return "down";
            }
            else if (beforeCoord.getRow() === newCoord.getRow()) {
                if (beforeCoord.getCol() === newCoord.getCol() + 1)
                    return "right";
                else
                    return "left";
            }
            else {   //si consigo rotar las imagenes esto pasara a topRight, topLeft, downRight, downLeft
                if (beforeCoord.getRow() === newCoord.getRow() + 1)
                    return "up";
                else
                    return "down";
            }
        }

        paintBoats(path) {
            let before;
            for (let i = 0; i < path.Count; i++) {
                let coord = path[i];
                if (coord === path[0])
                    before = coord;
                else if (coord !== path[0] && coord !== path[path.Count - 1]) {
                    coord.paintCoordPath();
                    before = coord;
                }
            }
        }*/



        }
}
