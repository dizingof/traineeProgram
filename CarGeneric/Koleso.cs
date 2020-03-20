using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    abstract class Koleso
    {
        private string Name { get; }
        public Koleso(string name)
        {
            Name = name;
        }
        public void GetInfoKoleso()
        {
            Console.WriteLine(Name);
        }
    }
}
