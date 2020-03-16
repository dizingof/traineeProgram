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


            ConveerKoles conveerKoles = new ConveerKoles();        
            ConveerDvigatelei conveerDvigatelei = new ConveerDvigatelei();
            ConveerKuzovov conveerKuzovov = new ConveerKuzovov();
            ConveerAvto conveerAvto = new ConveerAvto();
            var cityCarObj = conveerAvto.CreateCityCar(conveerKoles.CreateCityKoleso(), conveerDvigatelei.CreateStandartMotor(), conveerKuzovov.CreateSedan());
            var sportCarObj = conveerAvto.CreateSportCar(conveerKoles.CreateSportKoleso(), conveerDvigatelei.CreateSportMotor(), conveerKuzovov.CreateHetchback());
            var vnedorognikCarObj = conveerAvto.CreateVnedorognikCar(conveerKoles.CreateVnedorognikKoleso(), conveerDvigatelei.CreateVnedorognikMotor(), conveerKuzovov.CreateVnedorognikKuzov());

           


        }
       
    }
}
