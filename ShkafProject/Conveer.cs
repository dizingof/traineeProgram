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
        public Dictionary<string, object> SozdanieRazmerov(Dictionary<string, int> naborRazmerov)
        {
            Visota visota = new Visota(naborRazmerov["Visota"]);
            Shirina shirina = new Shirina(naborRazmerov["Shirina"]);
            Dlina dlina = new Dlina(naborRazmerov["Dlina"]);
            Glubina glubina = new Glubina(naborRazmerov["Glubina"]);

            Dictionary<string, object> razmeri = new Dictionary<string, object>();
            razmeri.Add("Visota", visota);
            razmeri.Add("Shirina", shirina);
            razmeri.Add("Dlina", dlina);
            razmeri.Add("Glubina", glubina);

            return razmeri;

        }
   
        public Parametri SozdanieParametrov(Dictionary<string, object> razmeri)
        {
            Parametri parametri = new Parametri((Visota)razmeri["Visota"], (Shirina)razmeri["Shirina"], (Dlina)razmeri["Dlina"], (Glubina)razmeri["Glubina"]);
            return parametri;
        }


        public string VvodCveta()
        {
            Console.WriteLine("Vvedite cvet polki");
            string cvetVibor = Console.ReadLine();
            return cvetVibor;
        }

        public Cvet SozdanieCveta(String cvetVibor)
        {
            Cvet cvet = new Cvet(cvetVibor);
            return cvet;
        }

        public Polka SozdaniePolki(Parametri parametri, Cvet cvet)
        {
            Polka polka = new Polka(parametri, cvet);
            return polka;
        }

        public Shkaf SozdanieShkafa(Parametri parametri, Cvet cvet, Polka polka)
        {
            Shkaf shkaf = new Shkaf(parametri, cvet, polka);
            return shkaf;
        }




    }
}
