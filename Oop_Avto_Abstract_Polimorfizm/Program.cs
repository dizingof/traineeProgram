﻿using Oop_Avto_Abstract_Polimorfizm.Conveers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            ConveerKoles conveerKoles = new ConveerKoles();
            conveerKoles.ViborTipaKolesa();
            ConveerDvigatelei conveerDvigatelei = new ConveerDvigatelei();
            conveerDvigatelei.ViborTipaDvigatelya();
            ConveerKuzovov conveerKuzovov = new ConveerKuzovov();
            conveerKuzovov.ViborTipaKuzova();
            ConveerAvto conveerAvto = new ConveerAvto();
            conveerAvto.CreateCityCar();
        }
    }
}
