using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Cell
    {
        bool sostoyanie;
        int X;
        int Y;

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Cell
    {
        public Position Position { get; private set; }
        public bool IsAlive { get; set; }
        public Cell[] Neighbours { get; set; }

        public Cell(Position position, bool isAlive = false)
        {
            Position = position;
            IsAlive = isAlive;
        }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
