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
            Console.WriteLine("Vvedite razmer visoti shkafa");
            int razmerVisoti = int.Parse(Console.ReadLine());
            Visota visotaShkafa = new Visota(razmerVisoti);

            Console.WriteLine("Vvedite razmer shirini shkafa");
            int razmerShirini = int.Parse(Console.ReadLine());
            Shirina shirinaShkafa = new Shirina(razmerShirini);

            Console.WriteLine("Vvedite razmer dlini shkafa");
            int razmerDlini = int.Parse(Console.ReadLine());
            Dlina dlinaShkafa = new Dlina(razmerDlini);

            Console.WriteLine("Vvedite razmer glubini shkafa");
            int razmerGlubini = int.Parse(Console.ReadLine());
            Glubina glubinaShkafa = new Glubina(razmerGlubini);

            Console.WriteLine("Vvedite visotu polki");
            int razmervisotiPolki = int.Parse(Console.ReadLine());
            Visota visotaPolki = new Visota(razmervisotiPolki);

            Console.WriteLine("Vvedite shirinu polki");
            int razmerShiriniPolki = int.Parse(Console.ReadLine());
            Shirina shirinaPolki = new Shirina(razmerShiriniPolki);

            Console.WriteLine("Vvedite dlinu polki");
            int razmerDliniPolki = int.Parse(Console.ReadLine());
            Dlina dlinaPolki = new Dlina(razmerDliniPolki);

            Console.WriteLine("Vvedite cvet polki");
            string cvetVibor = Console.ReadLine();
            Cvet cvetPolki = new Cvet(cvetVibor);
            Polka polkaShkafa = new Polka(visotaPolki, shirinaPolki, dlinaPolki, cvetPolki);

            Console.WriteLine("Vvedite cvet shkafa");
            string cvetShkafa = Console.ReadLine();
            Cvet cvet = new Cvet(cvetShkafa);

            Shkaf shkaf = new Shkaf(visotaShkafa, shirinaShkafa, dlinaShkafa, glubinaShkafa, polkaShkafa, cvet);
            shkaf.OtobrazitVisotaShkafa();
            shkaf.OtobrazitShirinaShkafa();
            shkaf.OtobrazitDlinaShkafa();
            shkaf.OtobrazitGlubinaShkafa();
            
            shkaf.OtobrazitCvetShkafa();

            Console.ReadLine();



        }
    }
}
