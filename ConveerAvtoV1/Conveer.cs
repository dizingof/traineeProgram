using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveerAvtoV1
{
    public class Conveer
    {
        public void SozdanieAvto()
        {
            Kolesa myKolesa = new Kolesa();
            Console.WriteLine("Vvedite diametr koles");
            myKolesa.Diametr = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite vid koles");
            myKolesa.VidKoles = Console.ReadLine();
            Kuzov myKuzuv = new Kuzov();
            Console.WriteLine("Vvedite cvet kuzova");
            myKuzuv.cvetKuzova = Console.ReadLine();
            Console.WriteLine("Vvedite tip kuzova");
            myKuzuv.tipKuzova = Console.ReadLine();
            Motor myMotor = new Motor();
            Console.WriteLine("Vvedite moshnost motora");
            myMotor.Capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite tip motora: 1-diesel, 2-elektro, 3-benzin");
            // myMotor.VidMotora = myMotor.GetTipMotora(int.Parse(Console.ReadLine()));
            int a = int.Parse(Console.ReadLine());
            myMotor.VidMotora = (TipMotora)a;

            Car avto = new Car(myKuzuv, myKolesa,  myMotor);
            
     
           

            


            Console.WriteLine($"Vi vibrali avto s takimi parametrami:");
            Console.WriteLine($"diametr koles: {avto.UznatDiametrKoles()}");
            Console.WriteLine($"vid koles: {avto.Kolesa.VidKoles}");
            Console.WriteLine($"Tip Motora: {avto.Motor.VidMotora}");
            Console.WriteLine($"Capacity Motora: {avto.Motor.Capacity}");
            Console.WriteLine($"Tip Kuzova: {avto.Kuzov.tipKuzova}");
            Console.WriteLine($"Cvet Kuzova: {avto.Kuzov.cvetKuzova}");
           

        }
       
        
    }
}
