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
        public void VivodCityCar(CityCar сityCar)
        {
            сityCar.Koleso.GetNameKoleso();
            сityCar.Motor.GetTipTopliva();
            Console.WriteLine(сityCar.Kuzov);
            сityCar.Drive();
            сityCar.Koleso.Spinning();
            сityCar.Kuzov.CloseDoor();
            сityCar.Motor.VrashenieDvigatelya();


        }
        public void VivodSportCar(SportCar sportCar)
        {
            sportCar.Koleso.GetNameKoleso();
            sportCar.Motor.GetTipTopliva();
            Console.WriteLine(sportCar.Kuzov);
            sportCar.Drive();
            sportCar.Koleso.Spinning();
            sportCar.Kuzov.CloseDoor();
            sportCar.Motor.VrashenieDvigatelya();

        }
        public void VivodVnedorognikCar(VnedorognikCar vnedorognikCar)
        {
            vnedorognikCar.Koleso.GetNameKoleso();
            vnedorognikCar.Motor.GetTipTopliva();
            Console.WriteLine(vnedorognikCar.Kuzov);
            vnedorognikCar.Drive();
            vnedorognikCar.Koleso.Spinning();
            vnedorognikCar.Kuzov.CloseDoor();
            vnedorognikCar.Motor.VrashenieDvigatelya();

        }


    }
}
