using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Cvet:IGetInfo<string>
    {
        private string CvetShkafa;
        public Cvet(string cvetShkafa)
        {
            CvetShkafa = cvetShkafa;
        }

        public string GetInfo()
        {
            return CvetShkafa;
        }
    }
}
