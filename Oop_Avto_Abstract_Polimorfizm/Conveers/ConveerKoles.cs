using Oop_Avto_Abstract_Polimorfizm.Koleso;
using System;

namespace Oop_Avto_Abstract_Polimorfizm.Conveers
{
    class ConveerKoles
    {

        public void ViborTipaKolesa()
        {
            Console.WriteLine("Vvedite Tip Kolesa: 1 - CityKoleso, 2 - SportKoleso, 3 - VnedorognikKoleso");

            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    CreateCityKoleso();
                    break;
                case 2:
                    CreateSportKoleso();
                    break;
                case 3:
                    CreateVnedorognikKoleso();
                    break;
            }
        }

        public CityKoleso CreateCityKoleso()
        {
            Console.WriteLine("Vvedite Marku Kolesa");
            string nazvanie = Console.ReadLine();
            Console.WriteLine("Vvedite Diametr Kolesa");
            int diametr = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite Maksimalnuu Nagruzku Kolesa");
            int maxNagruzka = int.Parse(Console.ReadLine());

            CityKoleso cityKoleso = new CityKoleso(maxNagruzka, nazvanie, diametr);
            return cityKoleso;
        }

        public SportKoleso CreateSportKoleso()
        {
            Console.WriteLine("Vvedite Marku Kolesa");
            string nazvanie = Console.ReadLine();
            Console.WriteLine("Vvedite Diametr Kolesa");
            int diametr = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite Maksimalnuu Nagruzku Kolesa");
            int maxNagruzka = int.Parse(Console.ReadLine());

            SportKoleso sportKoleso = new SportKoleso(nazvanie, diametr, maxNagruzka);
            return sportKoleso;
        }

        public VnedorognikKoleso CreateVnedorognikKoleso()
        {
            Console.WriteLine("Vvedite Marku Kolesa");
            string nazvanie = Console.ReadLine();
            Console.WriteLine("Vvedite Diametr Kolesa");
            int diametr = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite Maksimalnuu Nagruzku Kolesa");
            int maxNagruzka = int.Parse(Console.ReadLine());

            VnedorognikKoleso vnedorognikKoleso = new VnedorognikKoleso(nazvanie, diametr, maxNagruzka);
            return vnedorognikKoleso;
        }
    }
}
