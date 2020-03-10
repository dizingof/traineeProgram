using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Grid
    {
        private Cell[,] space;
        public bool[,] mass = new bool[50, 50];


        private int sosediCount(int a, int b)
        {
            int sosedi = 0;
            if (a > 0 && mass[a - 1, b]) { sosedi++; }
            if (a > 0 && b < 49 && mass[a - 1, b + 1]) { sosedi++; }
            if (b < 49 && mass[a, b + 1]) { sosedi++; };
            if (a < 49 && b < 49 && mass[a + 1, b + 1]) { sosedi++; }
            if (a < 49 && mass[a + 1, b]) { sosedi++; }
            if (a < 49 && b > 0 && mass[a + 1, b - 1]) { sosedi++; }
            if (b > 0 && mass[a, b - 1]) { sosedi++; }
            if (a > 0 && b > 0 && mass[a - 1, b - 1]) { sosedi++; }
            return sosedi;
        }

        
    }
}
