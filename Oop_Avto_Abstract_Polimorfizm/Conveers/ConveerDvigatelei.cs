﻿using Oop_Avto_Abstract_Polimorfizm.Motor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Avto_Abstract_Polimorfizm.Conveers
{
    class ConveerDvigatelei
    {
        

        public SportMotor CreateSportMotor()
        {
            Console.WriteLine("Vvedite Marku Turbini");
            string turbina = Console.ReadLine();
            Console.WriteLine("Vvedite Moshnost Dvigatelya");
            int moshnost = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite Ves Dvigatelya");
            int ves = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite Tip Topliva");
            string tipTopliva = Console.ReadLine();

            SportMotor sportMotor = new SportMotor(turbina, moshnost, ves, tipTopliva);
            return sportMotor;
        }

        public StandartMotor CreateStandartMotor()
        {
            Console.WriteLine("Vvedite Marku Elektronnogo Zajiganiya");
            string elektronnoeZagiganie = Console.ReadLine();
            Console.WriteLine("Vvedite Moshnost Dvigatelya");
            int moshnost = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite Ves Dvigatelya");
            int ves = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite Tip Topliva");
            string tipTopliva = Console.ReadLine();

            StandartMotor standartMotor = new StandartMotor(elektronnoeZagiganie, moshnost, ves, tipTopliva);
            return standartMotor;
        }

        public VnedorognikMotor CreateVnedorognikMotor()
        {
            Console.WriteLine("Vvedite Tip polnogo privoda");
            string polniiPrivod = Console.ReadLine();
            Console.WriteLine("Vvedite Moshnost Dvigatelya");
            int moshnost = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite Ves Dvigatelya");
            int ves = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite Tip Topliva");
            string tipTopliva = Console.ReadLine();

            VnedorognikMotor vnedorognikMotor = new VnedorognikMotor(polniiPrivod, moshnost, ves, tipTopliva);
            return vnedorognikMotor;
        }
    }
}
