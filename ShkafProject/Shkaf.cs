using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Shkaf
    {
        private Visota VisotaShkafa;
        private Shirina ShirinaShkafa;
        private Dlina DlinaShkafa;
        private Glubina GlubinaShkafa;
        private Polka PolkaSgkafa;
        private Cvet CvetShkafa;

        public Shkaf(Visota visotaShkafa, Shirina shirinaShkafa, Dlina dlinaShkafa, Glubina glubinaShkafa, Polka polkaSgkafa, Cvet cvetShkafa)
        {
            VisotaShkafa = visotaShkafa;
            ShirinaShkafa = shirinaShkafa;
            DlinaShkafa = dlinaShkafa;
            GlubinaShkafa = glubinaShkafa;
            PolkaSgkafa = polkaSgkafa;
            CvetShkafa = cvetShkafa;

        }
        public void GetInfoShkaf<T>(IGetInfo<T> obj)
        {
            Console.WriteLine(obj.GetInfo());
        }

        
    }
}
