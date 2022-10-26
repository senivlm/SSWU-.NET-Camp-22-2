using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class RectangularMatrix
    {
        private readonly int[,] matrix;

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Columns
            { get { return matrix.GetLength(1); } }

        public RectangularMatrix()
        {
            this.matrix = new int[default, default];
        }

        public RectangularMatrix(int n)
        {
            this.matrix = new int[n, n];
        }

        public RectangularMatrix(int m, int n)
        {
            this.matrix = new int[m, n];
        }

        public int this[int i, int j]
        {
            get
            {
                if(this.matrix.GetLength(0) <= i || i < 0)
                {
                    Console.WriteLine("Index out of range"); //exception
                    return 0;
                }
                if (this.matrix.GetLength(1) <= j || j < 0)
                {
                    Console.WriteLine("Index out of range"); //exception
                    return 0;
                }

                return this.matrix[i, j];
            }
            set
            {
                this.matrix[i, j] = value;
            }
        }

        public void Initialize()
        {
            int k = 1;
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    this.matrix[i, j] = k;
                    k++;
                    
                }
            }
        }

        public void VerticalSnake()
        {
            int k = 1;

            for (int j = 0; j < this.matrix.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < this.matrix.GetLength(0); i++)
                    {
                        this.matrix[i, j] = k;
                        k++;
                    }
                }
                else
                {
                    for (int i = this.matrix.GetLength(0) - 1; i >= 0; i--)
                    {
                        this.matrix[i, j] = k;
                        k++;
                    }
                }
                
            }
        }

        public void DiagonalSnake()
        {
            if (this.matrix.GetLength(0) != this.matrix.GetLength(1))
            {
                Console.WriteLine("The matrix is not square"); //exception
            }

            int element = 1;
            int diagonalnumber = 0;

            for (int j = 0; j < this.matrix.GetLength(1); j++)
            {
                if (diagonalnumber % 2 == 0)
                {
                    int k = 0;
                    for (int i = j; i >= 0; i--)
                    {
                        this.matrix[i, k] = element;
                        element++;
                        k++;
                    }
                    diagonalnumber++;
                }
                else
                {
                    int k = j;
                    for (int i = 0; i <= j; i++)
                    {
                        this.matrix[i, k] = element;
                        element++;
                        k--;
                    }
                    diagonalnumber++;
                }          
            }

            for (int i = 1; i < this.matrix.GetLength(0); i++)
            {
                if (diagonalnumber % 2 == 0)
                {
                    int k = this.matrix.GetLength(0) - 1;
                    for (int j = i; j < this.matrix.GetLength(1); j++)
                    {
                        this.matrix[k, j] = element;
                        element++;
                        k--;
                    }
                    diagonalnumber++;
                }
                else
                {
                    int k = i;
                    for (int j = this.matrix.GetLength(1) - 1; j >= i; j--)
                    {
                        this.matrix[k, j] = element;
                        element++;
                        k++;
                    }
                    diagonalnumber++;
                }

            }
        }

        public void SpiralSnake()
        {
            int down = this.matrix.GetLength(0) - 1; //i
            int right = this.matrix.GetLength(1) - 1; //j
            int up = 0; //i
            int left = 0; //j
            int k = 1;
            while (k <= this.matrix.GetLength(0) * this.matrix.GetLength(1))
            {
                for (int i = up; i <= down; i++)
                {
                    this.matrix[i, left] = k;
                    k++;
                }
                left++;

                for (int j = left; j <= right; j++)
                {
                    this.matrix[down, j] = k;
                    k++;
                }             
                down--;

                for (int i = down ; i >= up; i--)
                {
                    this.matrix[i, right] = k;
                    k++;
                }
                right--;

                for (int j = right; j >= left; j--)
                {
                    this.matrix[up, j] = k;
                    k++;
                }
                up++;
            }
        }

        public override string ToString()
        {
            string res = String.Empty;

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    res += this.matrix[i, j] + " ";
                }
                res += "\n";
            }

            

            return res;
        }





    }
}
