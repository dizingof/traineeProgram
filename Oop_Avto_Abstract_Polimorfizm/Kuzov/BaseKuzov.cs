using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Kuzov
{
    abstract public class BaseKuzov
    {
        private int Ves { get; set; }
        private string Cvet { get; set; }

        public BaseKuzov(int ves, string cvet)
        {
            Ves = ves;
            Cvet = cvet;
        }
        public abstract void CloseDoor();
    }
}
