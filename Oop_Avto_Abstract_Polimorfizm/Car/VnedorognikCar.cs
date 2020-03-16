using Oop_Avto_Abstract_Polimorfizm.Koleso;
using Oop_Avto_Abstract_Polimorfizm.Kuzov;
using Oop_Avto_Abstract_Polimorfizm.Motor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Car
{
    class VnedorognikCar:BaseCar
    {
        public VnedorognikKoleso Koleso { get; set; }
        public VnedorognikMotor Motor { get; set; }
        public VnedorognikKuzov Kuzov { get; set; }

        public override void Drive()
        {
            Console.WriteLine("Drive VnedorognikCar");
        }
    }
}
