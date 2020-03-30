using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_delegat_
{
    class Car
    {

        public void Zavoditsya()
        {
            EventUskoryatsa("1");
        }

        public event Action EventUskoryatsa1;



        public event Action<string> EventUskoryatsa;


        public void VzyatPassagira()
        {
            EventOpenDoor(2);
        }

        public event Action<int> EventOpenDoor;






        
    }
}
