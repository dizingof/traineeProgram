using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Glubina:IGetInfo<int>
    {
        private int RazmerGlubini;
        public Glubina(int razmerGlubini)
        {
            RazmerGlubini = razmerGlubini;
        }
        public int GetInfo()
        {
            return RazmerGlubini;
        }
    }
}
