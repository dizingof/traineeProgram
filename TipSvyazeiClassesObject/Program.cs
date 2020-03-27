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
            var a = new Chelovek();
            var b = new Mozg();
            a.Mozg = b;
        }

    }

    ////////////////////Asocicia///////////////////
    class TV 
    {
        
    }
    
    class Room
    {
        public TV Televizor { get; set; } 
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
    interface IPeople
    {
        void Move();
    }
    
    
    class Dom
    {
        public IPeople People { get; set; }
        public Dom(IPeople peopleObj)
        {
            People = peopleObj;
        }
    }



}
