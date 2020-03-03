using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    class BaseHuman
    {
        public string golova;
        public string ruki;
        public string nogi;

        public void Spat()
        {
            Console.WriteLine("baseHuman spit");
        }
        public void UpotrevlyatEdu()
        {
            Console.WriteLine("baseHuman upotreblyaet edu");
        }

        public BaseHuman(string golova, string ruki, string nogi)
        {
            this.golova = golova;
            this.ruki = ruki;
            this.nogi = nogi;
        }
    }
}
