﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Koleso
{
    class VnedorognikKoleso:BaseKoleso
    {
        public int MaxNagruzka { get; set; }
        public VnedorognikKoleso(string nazvanie, int diametr, int maxnagruzka) : base(nazvanie, diametr)
        {
            MaxNagruzka = maxnagruzka;
          
        }
        public override void Spinning()
        {
            Console.WriteLine("Krutitsya VnedorognikKoleso");
        }
    }
}
