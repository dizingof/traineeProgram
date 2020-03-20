using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGeneric
{
    class AllRoadKoleso:Koleso, ISpining
    {
        private int VisotaProtektora { get; }
        public AllRoadKoleso(int visotaProtektora, string name) : base(name)
        {
            VisotaProtektora = visotaProtektora;
        }

        public void Spining()
        {
            Console.WriteLine("Krutitsya All Road Koleso");
        }
        public void GetInfoAllRoadKoleso()
        {
            Console.WriteLine(VisotaProtektora);
        }
    }
}
