using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    public class Dlina:IGetInfo
    {
        private int RazmerDlini;
        public Dlina(int razmerDlini)
        {
            RazmerDlini = razmerDlini;
        }
        public int GetDlina()
        {
            return RazmerDlini;
        }

        public void GetInfo()
        {
            Console.WriteLine(GetDlina());
        }
    }
}
