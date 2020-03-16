using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Kuzov
{
    class VnedorognikKuzov:BaseKuzov
    {
        private string Zashita { get; set; }

        public VnedorognikKuzov(string zashita, int ves, string cvet) : base(ves, cvet)
        {
            Zashita = zashita;
        }

        public override void CloseDoor()
        {
            Console.WriteLine("Open door Vnedorognik");
        }
    }
}
