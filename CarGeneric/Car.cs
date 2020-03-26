using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    class Car<T, U, N> where T: Motor<string, int>, IZapusk where U: Koleso, ISpining
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
            EventPoehat.Invoke();
        }
        public event PoehatDelegat EventPoehat = null;

        /////////////////////////////////////////////////
        public void ZapuskUskorenia()
        {
            EventUskoryatsa("parametr iz sobitiya");
        }
       
        public event Action<string> EventUskoryatsa = null;
        /////////////////////////////////////////////////


    }
    public delegate void PoehatDelegat();
   



    public delegate void StartDelegate();
}
