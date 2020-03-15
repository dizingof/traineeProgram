using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Kuzov
{
    abstract class BaseKuzov
    {
        private int Ves { get; set; }
        private string Cvet { get; set; }
        public abstract void OpenDoor();
    }
}
