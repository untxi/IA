using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athosa.Logic
{
    class Tuple
    {
        private string row = "";
        private string col = "";

        void Tuple(string pRow, string pCol)
        {
            row = pRow;
            col = pCol;
        }

        string getRow()
        {
            return row;
        }
        string getCol()
        {
            return col;
        }
        void setRow(string pRow)
        {
            row = pRow;
        }
        void setCol(string pCol)
        {
            col = pCol;
        }
    }
    
    private static getRow() {

    }


    class SearchAStar
    {
        private Tuple init;
        private Tuple end;
        private List<List<string>> matrix;
        private float probability;
        private bool found;
        private bool hasPath;
        private List<string> opened;
        private List<string> closed;

        static void SearchAStar(Tuple pInit, Tuple pEnd,List<List<string>> pMatrix, float pProbability)
        {
            init = pInit;
            end = pEnd;
            matrix = pMatrix;
            probability = pProbability;
            found = false;
            hasPath = true;
        }

        static void start()
        {
            insertIntoOpened(new Coord(init.getRow(), init.getCol(), estimate(init)));    //Insertamos el inicio en abierta

        }

        //metodos por hacer
        /*
         start() {
        this.insertIntoOpened(new Coord(this.init.getRow(), this.init.getCol(), this.estimate(this.init)));    //Insertamos el inicio en abierta
        let actual;
        while (!this.found && this.hasPath) {
            actual = this.getFromOpened();  //obtenemos el menor valor de abierta
            this.insertIntoClosed(actual);
            if (actual.getRow() === this.end.getRow() && actual.getCol() === this.end.getCol())  //es solucion
                this.found = true;
            else {  //caso base, final
                this.expandNode(actual);
                if (this.opened.length === 0 && !this.found)
                    this.hasPath = false;
            }

        }
        if (this.found) {
            let path = this.buildSolutionPath(); //devolver camino
            this.paintBoats(path);
        }
        else
            alert("No hay camino");
    }



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

    modifyCoordInList(coord, list){
        let found = false;
        let i = 0;
        while(!found && i < list.length){
            if(list[i].getRow() === coord.getRow() && list[i].getCol() === coord.getCol()){
                found = true;
                list[i] = coord;
            }
            i++;
        }
        
    }

    getCoordFromList(coord, list){
        let elem =  list.find(function(e) { 
            if(e.getRow() === coord.getRow() && e.getCol() === coord.getCol()) 
            return e;
        });
        return elem;
    }

    coordInList(coord, list){
        return list.some(function(e) { 
            if(e.getRow() === coord.getRow() && e.getCol() === coord.getCol()) 
                return true;
        })
    }
    compareFunction(a, b) {
        if (a.getEstimation() === 0)
            return -1;
        else if (b.getEstimation() === 0)
            return 1;
        else if (a.getEstimation() + a.getDistFromOrigin() < b.getEstimation() + b.getDistFromOrigin())
            return -1;
        else if (a.getEstimation() + a.getDistFromOrigin() === b.getEstimation() + b.getDistFromOrigin())
            return 0;
        else
            return 1;
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



    buildSolutionPath() {
        if (this.found) {
            this.solution = [];
            this.buildSolutionPathRec(this.closed[this.closed.length - 1]);
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


    estimate(coord) {
        let row = coord.getRow();
        let col = coord.getCol();
        if (row == this.end.getRow() && col == this.end.getCol())
            return 0;
        else if (row === this.end.getRow())
            return Math.abs(col - this.end.getCol());
        else if (col === this.end.getCol())
            return Math.abs(row - this.end.getRow());
        else {
            let dRow = Math.abs(row - this.end.getRow());
            let dCol = Math.abs(col - this.end.getCol());
            return Math.sqrt(Math.pow(dRow, 2) + Math.pow(dCol, 2));
        }
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
        for (let i = 0; i < path.length; i++) {
            let coord = path[i];
            if (coord === path[0])
                before = coord;
            else if (coord !== path[0] && coord !== path[path.length - 1]) {
                coord.paintCoordPath();
                before = coord;
            }
        }
    }*/



    }
}
