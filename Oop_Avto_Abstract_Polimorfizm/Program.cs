using Oop_Avto_Abstract_Polimorfizm.Conveers;
using Oop_Avto_Abstract_Polimorfizm.Koleso;
using Oop_Avto_Abstract_Polimorfizm.Kuzov;
using Oop_Avto_Abstract_Polimorfizm.Motor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Viberite tip avto 1 - City Car, 2 - Sport Car, 3 - Vnedorognik");
            ConveerKoles conveerKoles = new ConveerKoles();        
            ConveerDvigatelei conveerDvigatelei = new ConveerDvigatelei();
            ConveerKuzovov conveerKuzovov = new ConveerKuzovov();
            ConveerAvto conveerAvto = new ConveerAvto();
            int selection = int.Parse(Console.ReadLine()); 
            switch (selection)
            {
                case 1:
                    var cityCarObj = conveerAvto.CreateCityCar(conveerKoles.CreateCityKoleso(), conveerDvigatelei.CreateStandartMotor(), conveerKuzovov.CreateSedan());
                    conveerAvto.VivodCityCar(cityCarObj);
                    Console.ReadLine();
                    break;
                case 2:
                    var sportCarObj = conveerAvto.CreateSportCar(conveerKoles.CreateSportKoleso(), conveerDvigatelei.CreateSportMotor(), conveerKuzovov.CreateHetchback());
                    conveerAvto.VivodSportCar(sportCarObj);
                    Console.ReadLine();
                    break;
                case 3:
                    var vnedorognikCarObj = conveerAvto.CreateVnedorognikCar(conveerKoles.CreateVnedorognikKoleso(), conveerDvigatelei.CreateVnedorognikMotor(), conveerKuzovov.CreateVnedorognikKuzov());
                    conveerAvto.VivodVnedorognikCar(vnedorognikCarObj);
                    Console.ReadLine();
                    break;
            }
            
           
            






        }
       
    }
}
