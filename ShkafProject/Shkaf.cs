using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Shkaf
    {
        private Parametri ParametriShkafa;
        private Cvet CvetShkafa;
        private Polka PolkaSgkafa;

        public Shkaf(Parametri parametriShkafa, Cvet cvetShkafa, Polka polkaSgkafa)
        {
            ParametriShkafa = parametriShkafa;
            CvetShkafa = cvetShkafa;
            PolkaSgkafa = polkaSgkafa;

        }

        public void OtobrazitParametriShkafa()
        {
            ParametriShkafa.OtobrazitDlinu();
            ParametriShkafa.OtobrazitVisotu();
            ParametriShkafa.OtobrazitShirinu();
            ParametriShkafa.OtobrazitGlubinu();
        }

        public void OtobrazitCvetShkafa()
        {
            Console.WriteLine(CvetShkafa.GetCvet());
        }

        public void OtobrazitParametriPolki()
        {
            PolkaSgkafa.OtobrazitParametriPolki();
            
        }




    }
}
