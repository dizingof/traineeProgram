using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Stroku vivel metod soobshenii s delegatom");
        }
    }

    public delegate void Mydelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate myDelegate = new Mydelegate(MyClass.Method);
            myDelegate();
            Console.ReadKey();
        }
    }
}
