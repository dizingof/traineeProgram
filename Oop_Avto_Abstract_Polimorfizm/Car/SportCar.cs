﻿using Oop_Avto_Abstract_Polimorfizm.Koleso;
using Oop_Avto_Abstract_Polimorfizm.Kuzov;
using Oop_Avto_Abstract_Polimorfizm.Motor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Car
{
    class SportCar:BaseCar
    {
        private SportKoleso Koleso;
        private SportMotor Motor;
        private Hetchback Kuzov;

        public SportCar(SportKoleso koleso, SportMotor motor, Hetchback kuzovHetchback)
        {
            Koleso = koleso;
            Motor = motor;
            Kuzov = kuzovHetchback;

        }
        public override void Drive()
        {
            Console.WriteLine("Drive SportCar");
        }
    }
}
