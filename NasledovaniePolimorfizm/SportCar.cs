using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovaniePolimorfizm
{
    class SportCar:BaseCar
    {
        public string turbina;

        public SportCar(string turbina1, string kuzov1, string kolesa1, string dvigatel1):base(kuzov1, kolesa1, dvigatel1)
        {
            turbina = turbina1;
            kuzov = kuzov1;
            kolesa = kolesa1;
            dvigatel = dvigatel1;
        }
    }
}
