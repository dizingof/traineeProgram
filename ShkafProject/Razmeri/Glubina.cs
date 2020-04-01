using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Glubina:IGetInfo
    {
        private int RazmerGlubini;
        public Glubina(int razmerGlubini)
        {
            RazmerGlubini = razmerGlubini;
        }
        public int GetGlubina()
        {
            return RazmerGlubini;
        }
        public void GetInfo()
        {
            Console.WriteLine(GetGlubina());
        }
    }
}
