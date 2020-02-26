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
             
            Console.Write("vvedite kolichestvo incomes:\t");
            int incomeCountI = int.Parse(Console.ReadLine());
            Income[]  newIncome = new Income[incomeCountI];
            for (int i = 0; i < incomeCountI; i++)
            {                
                newIncome[i] = CreateIncome();
            }
           
            
            return newIncome;
        }
        private static Income CreateIncome()
        {
            //var income = new Income();
            //Console.Write("vvedite Nazvanie proekta:\t");
            //income.ProjectName = Console.ReadLine();
           // Console.Write("vvedite Summu project:\t");
           // income.Summa = int.Parse(Console.ReadLine());
            return new Income() { ProjectName = Console.ReadLine(), Summa = int.Parse(Console.ReadLine()) };
        }
    }
}
