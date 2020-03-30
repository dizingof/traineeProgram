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
        public void GetVisotaShkafa()
        {
            Console.WriteLine(VisotaShkafa.GetVisota()); 
        }
        public void GetShirinaShkafa()
        {
            Console.WriteLine(ShirinaShkafa.GetShirina());
        }
        public void GetDlinaShkafa()
        {
            Console.WriteLine(DlinaShkafa.GetDlina());
        }
        public void GetGlubinaShkafa()
        {
            Console.WriteLine(GlubinaShkafa.GetGlubina());
        }
        public void GetKolichestvoPolok()
        {
            Console.WriteLine(PolkaSgkafa.GetKolichestvoPolok());
        }
        public void GetCvetShkafa()
        {
            Console.WriteLine(PolkaSgkafa.GetKolichestvoPolok());
        }
    }
}
