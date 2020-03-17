using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Kuzov
{
    public class Sedan:BaseKuzov
    {
        private string Bagajnik { get; set; }

        public Sedan(string bagajnik, int ves, string cvet) : base(ves, cvet)
        {
            Bagajnik = bagajnik;
        }

        public override void CloseDoor()
        {
            Console.WriteLine("Close door Sedan");
        }
    }
}
