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
            Visota VisotaShkafa = new Visota(razmerVisoti);

            Console.WriteLine("Vvedite razmer shirini shkafa");
            int razmerShirini = int.Parse(Console.ReadLine());
            Shirina shirinaShkafa = new Shirina(razmerShirini);

            Console.WriteLine("Vvedite razmer dlini shkafa");
            int razmerDlini = int.Parse(Console.ReadLine());
            Dlina dlinaShkafa = new Dlina(razmerDlini);

            Console.WriteLine("Vvedite razmer glubini shkafa");
            int razmerGlubini = int.Parse(Console.ReadLine());
            Glubina glubinaShkafa = new Glubina(razmerGlubini);

            Console.WriteLine("Vvedite kolichestvo polok shkafa");
            int kolichestvoPolok = int.Parse(Console.ReadLine());
            Polka polkaShkafa = new Polka(kolichestvoPolok);

            Console.WriteLine("Vvedite cvet shkafa");
            string cvetShkafa = Console.ReadLine();
            Cvet cvet = new Cvet(cvetShkafa);

            Shkaf shkaf = new Shkaf(VisotaShkafa, shirinaShkafa, dlinaShkafa, glubinaShkafa, polkaShkafa, cvet);
            shkaf.GetVisotaShkafa();

            Console.ReadLine();



        }
    }
}
