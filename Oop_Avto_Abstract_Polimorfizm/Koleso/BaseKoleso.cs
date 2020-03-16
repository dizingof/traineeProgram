using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm
{
    abstract public class BaseKoleso
    {
        private string Nazvanie { get; set; }
        private int Diametr { get; set; }
        public BaseKoleso(string nazvanie, int diametr)
        {
            Nazvanie = nazvanie;
            Diametr = diametr;
        }



        public abstract void Spinning();
    }
}
