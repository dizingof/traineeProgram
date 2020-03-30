using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Polka
    {
        private int KolichestvoPolok;
        public Polka(int kolichestvoPolok)
        {
            KolichestvoPolok = kolichestvoPolok;
        }
        public int GetKolichestvoPolok()
        {
            return KolichestvoPolok;
        }
    }
}
