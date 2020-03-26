using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class MyClass
    {
        

        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return 1;
                else return 2;
                
            }
            set
            {
                
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass[0] = 1;
            myClass[1] = 2;
            myClass[2] = 3;
            myClass[3] = 4;
            myClass[4] = 5;

            Console.WriteLine(myClass[0]);
            Console.WriteLine(myClass[1]);
            Console.WriteLine(myClass[2]);
            Console.WriteLine(myClass[3]);
            Console.WriteLine(myClass[4]);

            Console.ReadKey();
        }
        

    }


}
