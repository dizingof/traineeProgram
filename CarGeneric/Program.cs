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

            Car<SportMotor, Koleso> sportCar = new Car<SportMotor, Koleso>(new SportMotor(myTurbina, myMarka, myMoshnost), new Koleso(nameKoleso));
            sportCar.ZavestiAvto();
            


            Car<ElektroMotor, Koleso> elektroCar = new Car<ElektroMotor, Koleso>(new ElektroMotor(myElektroKontroller, myMarka, myMoshnost), new Koleso(nameKoleso));
            elektroCar.ZavestiAvto();
            

            Console.ReadLine();

        }
    }
}
