using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite nazvanie Turbina");
            string myTurbina = Console.ReadLine();
            Console.WriteLine("Vvedite nazvanie Marki");
            string myMarka = Console.ReadLine();
            Console.WriteLine("Vvedite Moshnost");
            int myMoshnost = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite nazvanie ElektroKontroller");
            string myElektroKontroller = Console.ReadLine();
            Console.WriteLine("Vvedite nazvanie Kolesa");
            string nameKoleso = Console.ReadLine();
            Console.WriteLine("Vvedite nagruzku na koleso");
            int nagruzkaNaKoleso = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite visotu protektora");
            int visotaProtektora = int.Parse(Console.ReadLine());

        
            Car<SportMotor, SportKoleso> sportCar = new Car<SportMotor, SportKoleso>(new SportMotor(myTurbina, myMarka, myMoshnost), new SportKoleso(nagruzkaNaKoleso, nameKoleso));

            sportCar.ZavestiAvto(new SportMotor(myTurbina, myMarka, myMoshnost).Start);
            sportCar.Poehat();

            //ZavestiAvto zavestiAvto = sportCar.ZavestiAvto;
            //zavestiAvto();




            Car<ElektroMotor, AllRoadKoleso> elektroCar = new Car<ElektroMotor, AllRoadKoleso>(new ElektroMotor(myElektroKontroller, myMarka, myMoshnost), new AllRoadKoleso(visotaProtektora, nameKoleso));
            elektroCar.ZavestiAvto(new ElektroMotor(myElektroKontroller, myMarka, myMoshnost).Start);
            elektroCar.Poehat();



            Console.ReadLine();

        }
    }
}
