using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveerAvtoOOP
{
    class Conveer
    {
        public Car SozdanieAvto()
        {
            

            Car objectCar = new Car();
            
            var cvet = objectCar.CvetKuzova.Cvet.ViborColor();
            var typeKuzov = objectCar.TypeOfKuzov;
            var typeDvigatel = objectCar.DvigatelType;
            var CapaciryDvig = objectCar.DvigatelMoshnost;
            Console.WriteLine("Vi sobrali avtomobil s takimi parametrami");
            Console.WriteLine($"Cvet vashego avto: {cvet}");
            Console.WriteLine($"Tip kuzova: {typeKuzov}");
            Console.WriteLine($"Tip Dvigatelya: {typeDvigatel}");
            Console.WriteLine($"Moshnost Dvigatelya: {CapaciryDvig}");
            
            return objectCar;
        }

        
    }
}
