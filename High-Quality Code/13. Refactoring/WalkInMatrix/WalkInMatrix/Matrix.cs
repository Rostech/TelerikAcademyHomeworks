namespace WalkInMatrix
{
    using System;
    using System.Text;

    public class Matrix
    {
        private int width;
        private int[,] matrixField;

        public Matrix(int width)
        {
            this.Width = width;
            this.MatrixField = new int[this.Width, this.Width];
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                if(value <= 1 || 100 <= value)
                {
                    throw new ArgumentException("The matrix width has to be 1 <= n <= 100");
                }

                width = value;
            }
        }

        public int[,] MatrixField
        {
            get
            {
                return matrixField;
            }

            set
            {
                matrixField = value;
            }
        }

        public void WalkInTheMatrix()
        {
            Walk.StartWalking(this);
        }

        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();

            for(int i = 0; i < this.MatrixField.GetLength(0); i++)
            {
                for (int j = 0; j < this.MatrixField.GetLength(1); j++)
                {
                    strB.Append(String.Format("{0,3}", this.MatrixField[i, j]));
                }
                strB.Append("\n");
            }

            return strB.ToString();
        }
    }
}
