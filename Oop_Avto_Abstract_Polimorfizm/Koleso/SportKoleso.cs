﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Koleso
{
    class SportKoleso:BaseKoleso
    {
        public SportKoleso(string nazvanie, int diametr):base(nazvanie, diametr)
        {
            Nazvanie = nazvanie;
            Diametr = diametr;
        }
        public override void Spinning()
        {
            Console.WriteLine("Krutitsya SportKoleso");
        }
    }
}
