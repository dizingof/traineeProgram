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


            avto.EventOpenDoor += kuzov.OpenDoor;
           

            avto.Zavoditsya();
            Console.ReadKey();
        }
    }
}
