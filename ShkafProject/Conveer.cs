using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Conveer
    {

        public Dictionary<string, int> VvodRazmerov()
        {
            Console.WriteLine("Vvedite razmer visoti");
            int razmerVisoti = int.Parse(Console.ReadLine());

            Console.WriteLine("Vvedite razmer shirini");
            int razmerShirini = int.Parse(Console.ReadLine());

            Console.WriteLine("Vvedite razmer dlini");
            int razmerDlini = int.Parse(Console.ReadLine());

            Console.WriteLine("Vvedite razmer glubini");
            int razmerGlubini = int.Parse(Console.ReadLine());

            Dictionary<string, int> naborRazmerov =new Dictionary<string, int>();
            naborRazmerov.Add("Visota", razmerVisoti);
            naborRazmerov.Add("Shirina", razmerShirini);
            naborRazmerov.Add("Dlina", razmerDlini);
            naborRazmerov.Add("Glubina", razmerGlubini);


            return naborRazmerov;
        }
        public void SozdanieRazmerov(Dictionary<string, int> naborRazmerov)
        {
            Visota visota = new Visota(naborRazmerov["Visota"]);
            Shirina shirina = new Shirina(naborRazmerov["Shirina"]);
            Dlina dlinaShkafa = new Dlina(naborRazmerov["Dlina"]);
            Glubina glubinaShkafa = new Glubina(naborRazmerov["Glubina"]);


        }

        public string VvodCveta()
        {
            Console.WriteLine("Vvedite cvet polki");
            string cvetVibor = Console.ReadLine();
            return cvetVibor;
        }

        

    }
}
