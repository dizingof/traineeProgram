using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Motor
{
    abstract public class BaseMotor
    {
        private string TipTopliva { get; set; }
        private int Moshnost { get; set; }
        private int Ves { get; set; }
        public BaseMotor(int moshnost, int ves, string tipTopliva)
        {
            Moshnost = moshnost;
            Ves = ves;
            TipTopliva = tipTopliva;
        }
        public abstract void VrashenieDvigatelya();

    }
}
