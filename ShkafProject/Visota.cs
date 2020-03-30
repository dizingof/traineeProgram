using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
     class Visota:IGetInfo<int>
    {
        private int RazmerVisoti;
        public Visota(int razmerVisoti)
        {
            RazmerVisoti = razmerVisoti;
        }

        public int GetInfo()
        {
            return RazmerVisoti;
        }
    }
}
