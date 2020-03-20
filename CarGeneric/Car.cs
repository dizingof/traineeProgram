using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    class Car<T, U> where T:  IZapusk where U: ISpining
    {
       private T Dvigatel { get; set; }
        private U Koleso { get; set; }

        public Car(T dvigatel, U koleso)
        {
            Dvigatel = dvigatel;
            Koleso = koleso;
        }

        public void ZavestiAvto()
        {
            Dvigatel.Start();
        }

        public void Poehat()
        {
            Koleso.Spining();
        }

    }
}
