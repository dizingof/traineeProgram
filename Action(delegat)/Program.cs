using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_delegat_
{
    class Program
    {
        static void Main(string[] args)
        {
            var motor = new Motor();
            var avto = new Car();
            var kuzov = new Kuzov();


            avto.EventUskoryatsa += motor.KolenvalKrutitsya;
            avto.Zavoditsya();



            avto.EventOpenDoor += x => {  Console.WriteLine($"Vi otkrili {x} dverei"); } ;
            avto.VzyatPassagira();




            Func<int, int, int> DelegatForLambda = (x, y) =>  x + y;

            int sum = DelegatForLambda(3, 4);
            Console.WriteLine(sum);



            Console.ReadKey();
        }
    }
}
