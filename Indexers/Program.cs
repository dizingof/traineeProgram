using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class MyClass
    {
        private int[] myArray = new int[5];

        public int this[int index]
        {
            get
            {
                
                return myArray[index];
                
            }
            set
            {
                if(value !=3)
                myArray[index] = value;
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
