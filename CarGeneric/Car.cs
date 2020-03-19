using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    class Car<T> where T:  IZapusk 
    {
       private T Dvigatel { get; set; }
        
        public Car(T dvigatel)
        {
            Dvigatel = dvigatel;
        }

        public void ZavestiAvto()
        {
            Dvigatel.Start();
        }

      

    }
}
