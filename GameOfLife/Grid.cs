using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Grid
    {
        int dlina = 10;
        int shirina = 10;
    }
    public class Universe
    {
        private Cell[,] _space;
        private readonly int _spaceMeasurement;

        public Universe(int spaceMeasurement)
        {
            _spaceMeasurement = spaceMeasurement;
            SetEmptySpace();
        }
    }
}
