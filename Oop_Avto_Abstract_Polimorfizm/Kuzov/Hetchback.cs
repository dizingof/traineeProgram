using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Kuzov
{
    class Hetchback:BaseKuzov
    {
        private string Spoiler { get; set; }

        public Hetchback(string spoiler, int ves, string cvet):base(ves, cvet)
        {
            Spoiler = spoiler;
        }

        public override void CloseDoor()
        {
            Console.WriteLine("Close door Hetchbak");
        }
    }
}
