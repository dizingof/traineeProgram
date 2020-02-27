using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveerAvtoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Conveer objectConveer = new Conveer();
           
            
            
            objectConveer.VivodAvtoNaEkran(objectConveer.SozdnieAvto(objectConveer.Pokrasit(objectConveer.ViborKuzova(), objectConveer.ViborColor()), objectConveer.ViborDvigatelya()));
        }
        
    }
}
