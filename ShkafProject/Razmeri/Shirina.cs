using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    public class Shirina:IGetInfo
    {
        private int RazmerShirini { get; }
        public Shirina(int razmerShirini)
        {
            RazmerShirini = razmerShirini;
        }
        public int GetShirina()
        {
            return RazmerShirini;
        }
        public void GetInfo()
        {
            Console.WriteLine(GetShirina());
        }
    }
}
