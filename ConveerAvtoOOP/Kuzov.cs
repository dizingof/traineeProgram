using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveerAvtoOOP
{
    public class Kuzov
    {
        public string TypeOfKuzov { get; set; }
        public Color Cvet { get; set; }

        public string ViborKuzova()
        {
            Console.WriteLine("Vvedite tip kuzova:");
            TypeOfKuzov = Console.ReadLine();
            return TypeOfKuzov;
        }
    }
}
