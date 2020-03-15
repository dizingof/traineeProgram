using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Koleso
{
    public class CityKoleso : BaseKoleso
    {
        public CityKoleso(string nazvanie, int diametr)
        {
            Nazvanie = nazvanie;
            Diametr = diametr;
        }
        public override void Spinning()
        {
            Console.WriteLine("Krutitsya CityKoleso");
        }
    }
}
