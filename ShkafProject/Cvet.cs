using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Cvet
    {
        private string CvetShkafa;
        public Cvet(string cvetShkafa)
        {
            CvetShkafa = cvetShkafa;
        }

        public string GetCvet()
        {
            return CvetShkafa;
        }
    }
}
