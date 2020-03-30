using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metod();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                //throw;
            }
            Console.ReadLine();
            
        }

        public static void Metod()
        {
            try
            {
                throw new System.Exception();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
             throw;
            }

        }
    }
}
