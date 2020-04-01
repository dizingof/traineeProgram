using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    public class Visota:IGetInfo
    {
        private int RazmerVisoti;
        public Visota(int razmerVisoti)
        {
            RazmerVisoti = razmerVisoti;
        }

        public int GetVisota()
        {
            return RazmerVisoti;
        }
        public void GetInfo()
        {
            Console.WriteLine(GetVisota());
        }
    }
}
