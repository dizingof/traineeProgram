using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Kuzov
{
    abstract public class BaseKuzov
    {
       

        public BaseKuzov(int ves, string cvet)
        {
           
        }

        public abstract void CloseDoor();
    }
}
