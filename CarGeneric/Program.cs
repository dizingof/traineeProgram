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
            

            Car<SportMotor> sportCar = new Car<SportMotor>(new SportMotor(myTurbina, myMarka, myMoshnost));
            sportCar.ZavestiAvto();
            


            Car<ElektroMotor> elektroCar = new Car<ElektroMotor>(new ElektroMotor(myElektroKontroller, myMarka, myMoshnost));
            elektroCar.ZavestiAvto();
            

            Console.ReadLine();

        }
    }
}
