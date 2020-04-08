using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myslovo = "dibil";
            for (int i = 1; i <= myslovo.Length; i++)
            {
                
                if (i == myslovo.Length) 
                {
                    Console.WriteLine(i);
                }
                

            }
            Console.ReadLine();
        }
    }
}
