using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Cell
    {
        public bool Sostoyanie { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Cell[] Sosedi { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

     
}
