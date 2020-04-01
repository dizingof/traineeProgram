using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Polka
    {

        private Parametri ParametriPolki;
        private Cvet CvetPolki;


        public Polka(Parametri parametriPolki, Cvet cvetPolki)
        {
            ParametriPolki = parametriPolki;
            CvetPolki = cvetPolki;

        }
        public void OtobrazitParametriPolki()
        {
           
            ParametriPolki.OtobrazitVisotu();
            ParametriPolki.OtobrazitShirinu();
            ParametriPolki.OtobrazitDlinu();
        }
    
        public void OtobrazitCvetPolki()
        {
            Console.WriteLine(CvetPolki.GetCvet());
        }
    }
}
