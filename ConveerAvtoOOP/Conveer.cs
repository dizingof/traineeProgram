using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveerAvtoOOP
{
    class Conveer
    {
        Dvigatel dieselDvigatel = new Dvigatel() { Type= "disel", Сapacity = 1000 };
        Color cvet = new Color() { Name = "Sinii" };
        
        public static Car CreateCar(Dvigatel dieselDvigatel, Color cvet)
        {
            Car dieselCar = new Car() { Dvigatel = dieselDvigatel.Type, Color = cvet.Name };
            return dieselCar;
        }
    }
}
