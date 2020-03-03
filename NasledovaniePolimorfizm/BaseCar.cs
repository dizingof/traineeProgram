using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovaniePolimorfizm
{
    class BaseCar
    {
        private string kuzov;
        private string dvigatel;
        private string kolesa;


        public BaseCar(string kuzov1, string kolesa1, string dvigatel1)
        {
            kuzov = kuzov1;
            kolesa = kolesa1;
            dvigatel = dvigatel1;
        }

        public void Dvigetsya()
        {
            Console.WriteLine("Base car dvigetsya");
        }

        public void Razgonyaetsya()
        {
            Console.WriteLine("Base car Razgonyaetsya");
        }
        protected string GetCarInfo()
        {
            Console.WriteLine($"{kuzov}, {dvigatel}, {kolesa}");
            return $"{kuzov}, {dvigatel}, {kolesa}";
        }
       

    }
}
