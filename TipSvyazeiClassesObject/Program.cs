using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipSvyazeiClassesObject
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }

    ////////////////////Asocicia///////////////////
    class TV 
    {
        
    }
    
    class Room
    {
        public TV televizor { get; set; } 
    }


    ///////////////////Kompoziciya//////////////////
    class Mozg 
    {
        public int Productivity { get; set; }
    }

    class Chelovek
    {
        public Mozg Mozg { get; set; }

        public Chelovek()
        {
            Mozg = new Mozg();
        }
    }
    ///////////////////Agregaciya///////////////////
    class People
    {
        public int name { get; set; }
    }
    
    
    class Dom
    {
        public People People { get; set; }
        public Dom(People peopleObj)
        {
            People = peopleObj;
        }
    }



}
