using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveerAvtoOOP
{
    class Conveer
    {
        public  Kuzov ViborKuzova()
        {
            Kuzov objectKuzov = new Kuzov();
            Console.WriteLine("Vvedite tip kuzova");
            objectKuzov.TypeOfKuzov = Console.ReadLine();
            return objectKuzov;
        }
        public  Color ViborColor()
        {
            Color objectColor = new Color();
            Console.WriteLine("Vvedite Cvet kuzova");
            objectColor.Name = Console.ReadLine();
            return objectColor;
        }
        public  PokrasheniiKuzov Pokrasit(Kuzov objectKuzov, Color objectColor)
        {
            PokrasheniiKuzov objectPokrasheniiKuzov = new PokrasheniiKuzov();
            objectPokrasheniiKuzov.Type = objectKuzov.TypeOfKuzov;
            objectPokrasheniiKuzov.CvetKuzova = objectColor.Name;
            return objectPokrasheniiKuzov;
        }
        public  Dvigatel ViborDvigatelya()
        {
            Dvigatel objectDvigatel = new Dvigatel();
            Console.WriteLine("Vvedite tip dvigatelya");
            objectDvigatel.Type = Console.ReadLine();
            Console.WriteLine("Vvedite moshnost dvigatelya");
            objectDvigatel.Сapacity = int.Parse(Console.ReadLine());
            return objectDvigatel;
        }
        public  Car SozdnieAvto(PokrasheniiKuzov objectPokrasheniiKuzov, Dvigatel objectDvigatel)
        {
            Car avto = new Car();
            avto.Color = objectPokrasheniiKuzov.CvetKuzova;
            avto.Kuzov = objectPokrasheniiKuzov.Type;
            avto.DvigatelType = objectDvigatel.Type;
            avto.DvigatelMoshnost = objectDvigatel.Сapacity;
            return avto;
        }
        public  void VivodAvtoNaEkran(Car avto)
        {
            Console.WriteLine("Vi sobrali avtomobil s takimi parametrami");
            Console.WriteLine($"Cvet vashego avto: {avto.Color}");
            Console.WriteLine($"Tip kuzova: {avto.Kuzov}");
            Console.WriteLine($"Tip Dvigatelya: {avto.DvigatelType}");
            Console.WriteLine($"Moshnost Dvigatelya: {avto.DvigatelMoshnost}");
            Console.ReadKey();
        }
    }
}
