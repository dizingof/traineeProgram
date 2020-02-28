using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveerAvtoV1
{
   public class Car
    {
        public Kuzov Kuzov { get; set; }
        public Motor Motor { get; set; }
        public Kolesa Kolesa { get; set; }

        public Car(Kuzov kuzov, Kolesa kolesa, Motor motor)
        {
            Kuzov = kuzov;
            Kolesa = kolesa;
            Motor = motor;
            
        }
        public int UznatDiametrKoles()
        {
            return Kolesa.Diametr;
        }

    }
}
