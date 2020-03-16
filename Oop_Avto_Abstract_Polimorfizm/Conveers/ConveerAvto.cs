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
