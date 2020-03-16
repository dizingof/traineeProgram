using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Motor
{
    class VnedorognikMotor:BaseMotor
    {
        private string PolniiPrivod { get; set; }

        public VnedorognikMotor(string polniiPrivod, int moshnost, int ves, string tipTopliva) : base(moshnost, ves, tipTopliva)
        {
            PolniiPrivod = polniiPrivod;
        }



        public override void VrashenieDvigatelya()
        {
            Console.WriteLine("Vrashenie Standart dvigatelya");
        }
    }
}
