using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveerAvtoOOP
{
    public class Color
    {
        public string Name { get; set; } 
        public string ViborColor()
        {
           
            Console.WriteLine("Vvedite Cvet kuzova");
            Name = Console.ReadLine();
            return Name;
        }
    }
   
}
