using Oop_Avto_Abstract_Polimorfizm.Koleso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm
{
    abstract public class BaseKoleso:INameKoleso, ISpining
    {
        private string Nazvanie { get; set; }
        private int Diametr { get; set; }
        public BaseKoleso(string nazvanie, int diametr)
        {
            Nazvanie = nazvanie;
            Diametr = diametr;
        }


         void INameKoleso.GetNameKoleso()
        {
            Console.WriteLine(Nazvanie);
        }
        public abstract void Spinning();

        public void SuperSpining()
        {

        }
        void ISpining.GetNameKoleso()
        {
            Console.WriteLine(Nazvanie);
        }
    }
}
