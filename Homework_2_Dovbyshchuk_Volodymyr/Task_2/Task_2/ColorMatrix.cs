using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class ColorMatrix
    {
        private readonly int[,] matrix;

        public int MaxStreak { get; private set; }
        public int FinishX { get; private set; }
        public int FinishY { get; private set; }
        public int StartX { get; private set; }
        public int StartY { get; private set; }
        public int Color { get; private set; }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Columns
        {
            get { return matrix.GetLength(1); }
        }

        public ColorMatrix()
        {
            this.matrix = new int[default, default]; 
        }

        public ColorMatrix(int n, int m)
        {
            this.matrix = new int[n, m];
            MaxStreak = 0;
        }

        public ColorMatrix(int n)
        {
            this.matrix = new int[n, n];
        }

        public int this[int i, int j]
        {
            get
            {
                if (i >= this.matrix.GetLength(0) || i < 0)
                {
                    Console.WriteLine("Index out of array"); //exception
                    return 0;
                }
                if (j >= this.matrix.GetLength(1) || j < 0)
                {
                    Console.WriteLine("Index out of array"); //exception
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
            Random random = new Random();
            int tempMax = 1;

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    this.matrix[i, j] = random.Next(0, 16);
                    if (j > 0)
                    {
                        if (matrix[i, j] == matrix[i, j - 1])
                        {
                            tempMax++;
                        }
                        else
                        {
                            tempMax = 1;
                        }
                        if (tempMax >= MaxStreak)
                        {
                            Color = this.matrix[i, j];
                            MaxStreak = tempMax;
                            FinishX = i;
                            FinishY = j;
                            StartX = i;
                            StartY = j + 1 - tempMax;
                        }
                    }
                }
                tempMax = 1;
            }
        }

        public string OutPut()
        {
            string res = String.Empty;
            res = "Color: " + Color + "\nLenght of the longest line: " + MaxStreak + "\nStart index " + "X: " + StartX + " Y: " + StartY + "\nEnd index " + "X: " + FinishX + " Y: " + FinishY;
            return res;
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
