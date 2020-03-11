using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieExample
{
    class Animal
    {
        private int Vozrast { get; set; }
        public string Name { get; set; }
        protected string Vid { get; set; }

        public virtual void Display()
        {
            Console.WriteLine(Vozrast);
        }
    }
    class Cat:Animal
    {
        private int Ves { get; set; }
        public override void Display()
        {
            Console.WriteLine(Ves);
        }
    }
}
