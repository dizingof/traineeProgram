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
            var a1 = objectConveer.Pokrasit(objectConveer.ViborKuzova(), objectConveer.ViborColor());
            var a = objectConveer.SozdnieAvto(a1, objectConveer.ViborDvigatelya());
            objectConveer.VivodAvtoNaEkran(a);
        }
        
    }
}
