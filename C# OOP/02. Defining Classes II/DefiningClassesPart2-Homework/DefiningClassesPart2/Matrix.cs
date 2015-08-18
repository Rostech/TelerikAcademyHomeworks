namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
     8. Matrix

        Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

    */

    class Matrix<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[this.Rows, this.Cols];
        }

        public Matrix(T[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {

                }
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            set
            {
                this.rows = value;
            }
        }
        public int Cols
        {
            get
            {
                return this.cols;
            }
            set
            {
                this.cols = value;
            }
        }

        /*
            9. Matrix indexer

                Implement an indexer this[row, col] to access the inner matrix cells.

        */

        public T this[int rows, int cols]
        {
            get
            {
                if (rows < 0 || cols < 0 || cols >= this.Cols || rows >= this.Rows)
                    throw new IndexOutOfRangeException("Index is out of range!");
                return this.matrix[rows, cols];
            }
            set
            {
                if (rows < 0 || cols < 0 || cols >= this.Cols || rows >= this.Rows)
                    throw new IndexOutOfRangeException("Index is out of range!");
                this.matrix[rows, cols] = value;
            }
        }

        /*
         10. Matrix operations

            Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
            Throw an exception when the operation cannot be performed.
            Implement the true operator (check for non-zero elements).

        */

        public static Matrix<T> operator + (Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
                throw new ArgumentException("Invalid operation addition ! Matrixes are not the same size! ");
            Matrix<T> m3 = new Matrix<T>(m1.Rows, m1.Cols);
            for (int i = 0; i < m1.Rows; i++ )
            {
                for(int j = 0; j < m1.Cols; j++)
                {
                    m3[i, j] = (dynamic)m1[i, j] + m2[i, j];
                }
            }
            return m3;
        }

        public static Matrix<T> operator - (Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
                throw new ArgumentException("Invalid operation substraction ! Matrixes are not the same size! ");
            Matrix<T> m3 = new Matrix<T>(m1.Rows, m1.Cols);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    m3[i, j] = (dynamic)m1[i, j] - m2[i, j];
                }
            }
            return m3;
        }

        public static Matrix<T> operator * (Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Cols != m2.Rows)
                throw new ArgumentException("Invalid operation multiplication ! ");
            Matrix<T> m3 = new Matrix<T>(m1.Rows, m2.Cols);
            T sum = default(T);
            for(int m1Row = 0; m1Row < m1.Rows; m1Row++)
            {
                for(int m2Col = 0; m2Col < m2.Cols; m2Col++)
                {
                    sum = default(T);
                    for(int m1Col = 0; m1Col < m1.Cols; m1Col++)
                    {
                        sum += (dynamic)m1[m1Row, m1Col] * m2[m1Col, m2Col];
                    }
                    m3[m1Row, m2Col] = sum;
                }
            }
            return m3;
        }

        public static bool operator true(Matrix<T> m)
        {
            for (int i = 0; i < m.Rows; i++)
            {
                for(int j = 0; j < m.Cols; j++)
                {
                    if((dynamic)m[i,j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> m)
        {
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Cols; j++)
                {
                    if ((dynamic)m[i, j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for(int j = 0; j < this.Cols; j++)
                {
                    strb.Append(this.matrix[i, j] + " ");
                }
                strb.AppendLine();
            }
            return strb.ToString();
        }

    }
}
