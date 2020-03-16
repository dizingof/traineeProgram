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
    class ConveerAvto
    {
        public void ViborTipaAvto(CityKoleso koleso, StandartMotor motor, Sedan sedan, SportKoleso sportKoleso, SportMotor sportMotor, Hetchback kuzovHetchback, VnedorognikKoleso kolesoVnedorognik, VnedorognikMotor motorVnedorognik, VnedorognikKuzov kuzovVnedorognik)
        {
            Console.WriteLine("Vvedite Tip Avto: 1 - CityCar, 2 - SportCar, 3 - VnedorognikCar");

            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    CreateCityCar(koleso, motor, sedan);
                    break;
                case 2:
                    CreateSportCar(sportKoleso, sportMotor, kuzovHetchback);
                    break;
                case 3:
                    CreateVnedorognikCar(kolesoVnedorognik, motorVnedorognik, kuzovVnedorognik);
                    break;
            }
        }

        public CityCar CreateCityCar(CityKoleso koleso, StandartMotor motor, Sedan sedan)
        {
           CityCar сityCar = new CityCar(koleso, motor, sedan);
            return сityCar;
        }
        public SportCar CreateSportCar(SportKoleso sportKoleso, SportMotor sportMotor, Hetchback kuzovHetchback)
        {
            SportCar sportCar = new SportCar(sportKoleso, sportMotor, kuzovHetchback);
            return sportCar;
        }
        public VnedorognikCar CreateVnedorognikCar(VnedorognikKoleso kolesoVnedorognik, VnedorognikMotor motorVnedorognik, VnedorognikKuzov kuzovVnedorognik)
        {
            VnedorognikCar vnedorognikCar = new VnedorognikCar(kolesoVnedorognik, motorVnedorognik, kuzovVnedorognik);
            return vnedorognikCar;
        }


    }
}
