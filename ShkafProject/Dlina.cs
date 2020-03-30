using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Dlina:IGetInfo<int>
    {
        private int RazmerDlini;
        public Dlina(int razmerDlini)
        {
            RazmerDlini = razmerDlini;
        }
        public int GetInfo()
        {
            return RazmerDlini;
        }
    }
}
