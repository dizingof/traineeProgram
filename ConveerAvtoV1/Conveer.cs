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
            myKolesa.Diametr = int.Parse(Console.ReadLine());
            myKolesa.VidKoles = Console.ReadLine();
            Kuzov myKuzuv = new Kuzov();
            myKuzuv.cvetKuzova = Console.ReadLine();
            myKuzuv.tipKuzova = Console.ReadLine();
            Motor myMotor = new Motor();
            myMotor.Capacity = int.Parse(Console.ReadLine());
            myMotor.tipMotora = Console.ReadLine();

            Car avto = new Car(myKuzuv, myKolesa,  myMotor);
            
     
           

            


            Console.WriteLine($"Vi vibrali avto s takimi parametrami:");
            Console.WriteLine($"diametr koles: {avto.UznatDiametrKoles()}");
            Console.WriteLine($"vid koles: {avto.Kolesa.VidKoles}");
            Console.WriteLine($"Tip Motora: {avto.Motor.tipMotora}");
            Console.WriteLine($"Capacity Motora: {avto.Motor.Capacity}");
            Console.WriteLine($"Tip Kuzova: {avto.Kuzov.tipKuzova}");
            Console.WriteLine($"Cvet Kuzova: {avto.Kuzov.cvetKuzova}");
           

        }
       
        
    }
}
