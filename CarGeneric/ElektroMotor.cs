using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    class ElektroMotor : Motor<string, int>, IZapusk
    {

        private string ElektroKontroller { get; set; }
        public ElektroMotor(string elektroKontroller, string marka, int moshnost) : base(marka, moshnost)
        {
            ElektroKontroller = elektroKontroller;
        }

        public void Start()
        {
            Console.WriteLine("Zapusk Elektro Motora");
        }

        public void GetElektroKontroller()
        {
            Console.WriteLine(ElektroKontroller.ToString());
        }
    }
}
