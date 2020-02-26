using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsThrouthList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vvedite kolichestvo incomes:\t");
            int incomeCountI = int.Parse(Console.ReadLine());
            List<Income> incomes = new List<Income>();
            for (int i = 0; i < incomeCountI; i++)
            {
                incomes.Add(new Income(){ ProjectName = Console.ReadLine(),Summa = int.Parse(Console.ReadLine()) });
            }
            foreach(var i in incomes)
            {
                Console.WriteLine($"ProjectName: { i.ProjectName} Summa {i.Summa}");
            }
                     

        
        Console.ReadKey();

        }
}
}
