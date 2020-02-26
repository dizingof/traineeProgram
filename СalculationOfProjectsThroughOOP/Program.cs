using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СalculationOfProjectsThroughOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            VvodIncome();
            Console.ReadKey();
        }

        private static Income[] VvodIncome()
        {
            Income[] newIncome = null;
            Console.Write("vvedite kolichestvo incomes:\t");
            int incomeCountI = int.Parse(Console.ReadLine());
            for (int i = 0; i < incomeCountI; i++)
            {
                newIncome = new Income[incomeCountI];
                newIncome[i] = new Income();
                Console.Write("vvedite Nazvanie proekta:\t");
                newIncome[i].ProjectName = Console.ReadLine();
                Console.Write("vvedite Summu project:\t");
                newIncome[i].Summa = int.Parse(Console.ReadLine());

            }
           
            return newIncome;
        }
    }
}
