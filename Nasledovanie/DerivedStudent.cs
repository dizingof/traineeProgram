using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    class DerivedStudent : BaseHuman
    {
        public string odegda;



        public DerivedStudent(string golova1, string odegda1)
        {
            golova = golova1;
            odegda = odegda1;
        }
    }
}
