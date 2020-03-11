using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieExample
{
    class Cat : Animal
    {
        private int Ves { get; set; }
        public string Color { get; set; }
        public override void Display()
        {
            Console.WriteLine("cat");
        }
    }
}
