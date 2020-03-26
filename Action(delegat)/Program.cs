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


            avto.EventUskoryatsa += motor.KolenvalKrutitsya;


            avto.Zavoditsya();
            Console.ReadKey();
        }
    }
}
