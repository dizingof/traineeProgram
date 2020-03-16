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
    public class CityCar:BaseCar
    {

        public CityKoleso Koleso { get; set; }
        public StandartMotor Motor { get; set; }
        public Sedan Kuzov { get; set; }

        public CityCar(CityKoleso koleso, StandartMotor motor, Sedan kuzovSedan)
        {
            Koleso = koleso;
            Motor = motor;
            Kuzov = kuzovSedan;
            
        }

        

        public override void Drive()
        {
            Console.WriteLine("Drive CityCar");
        }
    }
}

