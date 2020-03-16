using Oop_Avto_Abstract_Polimorfizm.Car;
using Oop_Avto_Abstract_Polimorfizm.Koleso;
using Oop_Avto_Abstract_Polimorfizm.Kuzov;
using Oop_Avto_Abstract_Polimorfizm.Motor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Conveers
{
    class Conveer
    {
         CityKoleso koleso = new CityKoleso(100, "GoodYear", 22);
         public StandartMotor motor = new StandartMotor("avtomaticheskoeZagiganie", 150, 300, "benzin");
        public Sedan sedanKuzov = new Sedan("bigBagagnik", 1200, "red");



        CityCar avtoForCity = new CityCar(new CityKoleso(100, "GoodYear", 22), new Conveer().motor, new Conveer().sedanKuzov);

        public Conveer()
        {

        }
    }
}
