using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Cube
    {
        private int[,,] cube;

        public Cube()
        {
            this.cube = new int[default, default, default];
        }

        public Cube(int x, int y, int z)
        {
            this.cube = new int[z, y, x];
        }

        public Cube(int x)
        {
            this.cube = new int[x, x, x];
        }

        public int this[int i, int j, int k]
        {
            get
            {
                if (i >= this.cube.GetLength(0) || i < 0)
                {
                    return 0;
                }
                if (j >= this.cube.GetLength(1) || j < 0)
                {
                    return 0;
                }
                if (k >= this.cube.GetLength(2) || k < 0)
                {
                    return 0;
                }
                return this.cube[i, j, k];
            }
            set
            {
                this.cube[i, j, k] = value;
            }
        }

        public void Initialize()
        {
            Random rand = new Random();

            for (int i = 0; i < this.cube.GetLength(0); i++)
            {
                for (int j = 0; j < this.cube.GetLength(1); j++)
                {
                    for (int k = 0; k < this.cube.GetLength(2); k++)
                    {
                        this.cube[i, j, k] = rand.Next(0, 2);
                    }
                }
            }
        }

        public bool IsThroughHole()
        {
            int counter = 0;
            for (int i = 0; i < this.cube.GetLength(0); i++)
            {
                for (int j = 0; j < this.cube.GetLength(1); j++)
                {
                    if (this.cube[i, j, 0] == 0)
                    {
                        for (int k = 0; k < this.cube.GetLength(2); k++)
                        {
                            if (this.cube[i, j, k] == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == this.cube.GetLength(2))
                        {
                            return true;
                        }
                    }
                }
            }

            counter = 0;
            for (int i = 0; i < this.cube.GetLength(1); i++)
            {
                for (int j = 0; j < this.cube.GetLength(2); j++)
                {
                    if (this.cube[0, i, j] == 0)
                    {
                        for (int k = 0; k < this.cube.GetLength(0); k++)
                        {
                            if (this.cube[k, i, j] == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == this.cube.GetLength(2))
                        {
                            return true;
                        }
                    }
                }
            }

            counter = 0;
            for (int i = 0; i < this.cube.GetLength(0); i++)
            {
                for (int j = 0; j < this.cube.GetLength(2); j++)
                {
                    if (this.cube[i, 0, j] == 0)
                    {
                        for (int k = 0; k < this.cube.GetLength(0); k++)
                        {
                            if (this.cube[i, k, j] == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == this.cube.GetLength(2))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            string res = String.Empty;

            for (int i = 0; i < this.cube.GetLength(0); i++)
            {
                for (int j = 0; j < this.cube.GetLength(1); j++)
                {
                    for (int k = 0; k < this.cube.GetLength(2); k++)
                    {
                        res += this.cube[i, j, k] + " ";
                    }
                    res += "\n";
                }
                res += "\n";
            }

            return res;
        }


    }
}