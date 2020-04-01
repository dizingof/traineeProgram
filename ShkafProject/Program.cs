using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShkafProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Conveer myConv =new Conveer();
            Console.WriteLine("Vvod razmerov polki");
            Dictionary<string, int> naborRazmerovPolki = myConv.VvodRazmerov();
            Dictionary<string, object> razmeriPolki = myConv.SozdanieRazmerov(naborRazmerovPolki);
            Parametri parametriPolki = myConv.SozdanieParametrov(razmeriPolki);
            String vvedenniyCvetPolki = myConv.VvodCveta();
            Cvet cvetPolki = myConv.SozdanieCveta(vvedenniyCvetPolki);
            Polka polka = myConv.SozdaniePolki(parametriPolki, cvetPolki);


            Console.WriteLine("Vvod razmerov Shkafa");
            Dictionary<string, int> naborRazmerovShkafa = myConv.VvodRazmerov();
            Dictionary<string, object> razmeriShkafa = myConv.SozdanieRazmerov(naborRazmerovShkafa);
            Parametri parametriShkafa = myConv.SozdanieParametrov(razmeriShkafa);
            String vvedenniyCvetShkafa = myConv.VvodCveta();
            Cvet cvetShkafa = myConv.SozdanieCveta(vvedenniyCvetShkafa);
            Shkaf shkaf = myConv.SozdanieShkafa(parametriShkafa, cvetShkafa, polka);

            Console.WriteLine("-----------------------------------------");
            polka.OtobrazitParametriPolki();
            polka.OtobrazitCvetPolki();
            Console.WriteLine("-----------------------------------------");
            shkaf.OtobrazitParametriShkafa();
            shkaf.OtobrazitCvetShkafa();
            



            Console.ReadLine();



        }
    }
}
