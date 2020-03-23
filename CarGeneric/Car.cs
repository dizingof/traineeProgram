using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    class Car<T, U> where T: Motor<string, int>, IZapusk where U: Koleso, ISpining
    {
        public T Dvigatel { get; set; }
        private U Koleso { get; set; }

        public Car(T dvigatel, U koleso)
        {
            Dvigatel = dvigatel;
            Koleso = koleso;
        }

        public void ZavestiAvto(StartDelegate startDelegate)
        {

            Console.WriteLine("Vivod starta cherez delegat}");
            startDelegate();
        }

        public void Poehat()
        {
            Koleso.Spining();
        }

        

    }

    public delegate void StartDelegate();
}
