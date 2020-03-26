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

        public string this[string Name]
        {
            get
            {
                if(Name == "Motor") 
                {
                    
                    return Motor.Name;
                }
                else if(Name == "Koleso")
                {
                    var nameKoleso = new Kolesa().Name;
                    return nameKoleso;
                }
                else if (Name == "Kuzov")
                {
                    var nameKuzov = new Kuzov().Name;
                    return nameKuzov;
                }
                else
                {
                    return "ne vernoe znachenie";
                }
            }
            set
            {
                if (Name == "Motor")
                {
                    new Motor().Name = value;
                    
                }
                else if (Name == "Koleso")
                {
                    new Kuzov().Name = value;
                }
                else if (Name == "Kuzov")
                {
                    new Kolesa().Name = value;
                }
               

            }
        }

        
    }
}
