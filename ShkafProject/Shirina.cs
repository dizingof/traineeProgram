using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Shirina:IGetInfo<int>
    {
        private int RazmerShirini { get; }
        public Shirina(int razmerShirini)
        {
            RazmerShirini = razmerShirini;
        }
        public int GetInfo()
        {
            return RazmerShirini;
        }
    }
}
