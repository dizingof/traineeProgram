using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Parametri
    {
        private Visota Visota;
        private Shirina Shirina;
        private Dlina Dlina;
        private Glubina Glubina;
        


        public Parametri(Visota visota, Shirina shirina, Dlina dlina, Glubina glubina)
        {
            Visota = visota;
            Shirina = shirina;
            Dlina = dlina;
            Glubina = glubina;
                      

        }

        public void OtobrazitVisotu()
        {
            Console.WriteLine(Visota.GetVisota());
        }
        public void OtobrazitShirinu()
        {
            Console.WriteLine(Shirina.GetShirina());
        }
        public void OtobrazitDlinu()
        {
            Console.WriteLine(Dlina.GetDlina());
        }
        public void OtobrazitGlubinu()
        {
            Console.WriteLine(Glubina.GetGlubina());
        }
              
    }
}
