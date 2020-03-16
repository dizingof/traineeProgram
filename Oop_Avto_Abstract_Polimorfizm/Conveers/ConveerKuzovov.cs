using Oop_Avto_Abstract_Polimorfizm.Kuzov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Conveers
{
    class ConveerKuzovov
    {
        public void ViborTipaKuzova()
        {
            Console.WriteLine("Vvedite Tip Kuzova: 1 - Hetchback, 2 - Sedan, 3 - VnedorognikKuzov");

            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    CreateHetchback();
                    break;
                case 2:
                    CreateSedan();
                    break;
                case 3:
                    CreateVnedorognikKuzov();
                    break;
            }
        }

        public Hetchback CreateHetchback()
        {
            Console.WriteLine("Vvedite Marku Spoilera");
            string spoiler = Console.ReadLine();
            Console.WriteLine("Vvedite Ves Kuzova");
            int ves = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite cvet Kuzova");
            string cvet = Console.ReadLine();

            Hetchback hetchback = new Hetchback(spoiler, ves, cvet);
            return hetchback;
        }

        public Sedan CreateSedan()
        {
            Console.WriteLine("Vvedite Formu bagajnika");
            string bagajnik = Console.ReadLine();
            Console.WriteLine("Vvedite Ves Kuzova");
            int ves = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite cvet Kuzova");
            string cvet = Console.ReadLine();

            Sedan sedan = new Sedan(bagajnik, ves, cvet);
            return sedan;
        }

        public VnedorognikKuzov CreateVnedorognikKuzov()
        {
            Console.WriteLine("Vvedite vid zashiti");
            string zashita = Console.ReadLine();
            Console.WriteLine("Vvedite Ves Kuzova");
            int ves = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite cvet Kuzova");
            string cvet = Console.ReadLine();

            VnedorognikKuzov vnedorognikKuzov = new VnedorognikKuzov(zashita, ves, cvet);
            return vnedorognikKuzov;
        }
    }
}
