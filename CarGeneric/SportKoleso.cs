using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    class SportKoleso:Koleso, ISpining
    {
        private int Nagruzka { get; }
        public SportKoleso(int nagruzka, string name) : base(name)
        {
            Nagruzka = nagruzka;
        }

        public void Spining()
        {
            Console.WriteLine("Krutitsya sportivnoe koleso");
        }
        public void GetInfoSportKoleso()
        {
            Console.WriteLine(Nagruzka);
        }
    }

   
}
