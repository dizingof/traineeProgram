using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Tom";
            cat.Color = "red";
            cat.Display();

           
            Animal animal = (Animal)cat; //upcast

            Console.WriteLine(cat.GetHashCode());
            Console.WriteLine(animal.GetHashCode());

            Cat cat1 = new Cat();
            Animal animal1 = cat1; //upcast
            Cat cat2 = (Cat)animal1; //downcast
            //animal.Color;





            Console.ReadLine();


        }
    }
}
