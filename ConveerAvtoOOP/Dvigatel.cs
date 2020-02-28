using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveerAvtoOOP
{
    public class Dvigatel
    {
        
        public string Type { get; set; }
        public int Сapacity { get; set; }
        public string ViborTypeDvigatelya()
        {
            Console.WriteLine("Vvedite Tip Dvigatelya");
            Type = Console.ReadLine();
            return Type;
        }
        public int ViborCapacityDvigatelya()
        {
            Console.WriteLine("Vvedite Сapacity Dvigatelya");
            Сapacity = int.Parse(Console.ReadLine());
            return Сapacity;
        }
    }
}
