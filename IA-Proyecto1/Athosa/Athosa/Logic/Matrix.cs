/*using System;


namespace Athosa.Logic
{
    class Matrix
    {
        string[,] matrix;
        int n;
        int m;
        public Matrix(int pN, int pM)
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

        public bool inMatrixLimit(Tuple pCoord)
        {
            return (pCoord.getRow() < n && pCoord.getCol() < m);
        }
    }

}
*/