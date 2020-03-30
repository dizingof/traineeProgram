using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Polka:IGetInfo<int>
    {
        private int KolichestvoPolok;
        public Polka(int kolichestvoPolok)
        {
            KolichestvoPolok = kolichestvoPolok;
        }
        public int GetInfo()
        {
            return KolichestvoPolok;
        }
    }
}
