using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    abstract class Motor<T, U>
    {
       private T Marka { get; set; }
       private U Moshnost { get; set; }
       public Motor(T marka, U moshnost)
         {
            Marka = marka;
            Moshnost = moshnost;

        }

        public void GetInfo()
        {
            Console.WriteLine(Marka.ToString());
            Console.WriteLine(Moshnost.ToString());
        }

        
    }
}
