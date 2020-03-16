using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Motor
{
    public class StandartMotor:BaseMotor
    {
        private string ElektronnoeZagiganie { get; set; }

        public StandartMotor(string elektronnoeZagiganie, int moshnost, int ves, string tipTopliva) : base(moshnost, ves, tipTopliva)
        {
            ElektronnoeZagiganie = elektronnoeZagiganie;
        }



        public override void VrashenieDvigatelya()
        {
            Console.WriteLine("Vrashenie Standart dvigatelya");
        }
    }
}
