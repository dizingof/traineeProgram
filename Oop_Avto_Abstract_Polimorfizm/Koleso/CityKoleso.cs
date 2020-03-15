using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Koleso
{
    public class CityKoleso : BaseKoleso
    {
        public int MaxNagruzka { get; set; }
        public CityKoleso(int maxnagruzka, string nazvanie, int diametr) :base(nazvanie, diametr)
        {
            MaxNagruzka = maxnagruzka;
        }
        public override void Spinning()
        {
            Console.WriteLine("Krutitsya CityKoleso");
        }
    }
}
