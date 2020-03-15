using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Koleso
{
    class VnedorognikKoleso:BaseKoleso
    {
        public VnedorognikKoleso(string nazvanie, int diametr) : base(nazvanie, diametr)
        {
            Nazvanie = nazvanie;
            Diametr = diametr;
        }
        public override void Spinning()
        {
            Console.WriteLine("Krutitsya VnedorognikKoleso");
        }
    }
}
