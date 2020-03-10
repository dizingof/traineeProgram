using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A(1, 2);
            var b = new A(1, 2);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(a.Equals(b));
            Console.ReadLine();

            //Структуры сравниваются по значениям полей
            //Классы сравниваются по ссылке на кучу
        }
    }

    class A
    {
        public int X { get; set; }
        public int Y { get; set; }

        public A(int x, int y)
        {
            X = x;
            Y = y;
        }
       
    }
}
