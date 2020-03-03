using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovaniePolimorfizm
{
    class BaseCar
    {
        public string kuzov;
        public string dvigatel;
        public string kolesa;

        public void Dvigetsya()
        {
            Console.WriteLine("Base car dvigetsya");
        }

        public void Razgonyaetsya()
        {
            Console.WriteLine("Base car Razgonyaetsya");
        }

        public BaseCar(string kuzov1, string kolesa1, string dvigatel1) 
        {
            this.kuzov = kuzov1;
            this.kolesa = kolesa1;
            this.dvigatel = dvigatel1;
        }

    }
}
