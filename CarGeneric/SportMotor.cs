using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    class SportMotor : Motor<string, int>, IZapusk
    {
        private string Turbina { get; set; }
        public SportMotor(string turbina, string marka, int moshnost) :base(marka, moshnost)
        {
            Turbina = turbina;
        }

        public void Start()
        {
            Console.WriteLine("Zapusk Sport Motora");
        }
        public void GetTurbina()
        {
            Console.WriteLine(Turbina.ToString());
        }
        public void Uskoryatsa(string message)
        {
            Console.WriteLine($"Uskorenie{message}") ;
        }

    }

    
}
