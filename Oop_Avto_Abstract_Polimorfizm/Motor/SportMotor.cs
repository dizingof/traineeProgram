using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Motor
{
    class SportMotor:BaseMotor
    {
        private string Turbina { get; set; }

        public SportMotor(string turbina,int moshnost, int ves, string tipTopliva) : base(moshnost, ves, tipTopliva)
        {
            Turbina = turbina;
        }

       

        public override void VrashenieDvigatelya()
        {
            Console.WriteLine("Vrashenie sport dvigatelya");
        }
    }
}
