﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm
{
    abstract public class BaseKoleso
    {
        public string Nazvanie { get; set; }
        public int Diametr { get; set; }
      
        public abstract void Spinning();
    }
}
