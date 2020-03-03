using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovaniePolimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new SportCar("turbina", "kuzov", "kolesa", "dvigatel");
            a.GetSportCarInfo();
            var b = (BaseCar) a;
            Console.ReadLine();
        }
    }
}
