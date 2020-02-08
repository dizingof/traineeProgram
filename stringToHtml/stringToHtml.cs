using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           var enteredArray = VvodMasiva();
           var afterConvert = ConvertToHtml(enteredArray);
            WriteToFile(afterConvert);
            Console.ReadKey();
        }


        public static string [] VvodMasiva()
        {
            Console.Write("vvedite kolichestvo proectov:\t");
            int elementsCount = int.Parse(Console.ReadLine());

            string[] myArray = new string[elementsCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                
                Console.WriteLine($"Vvedite proect number {i + 1} ili dlya ostanovki vvoda vvedite \"stop\"");
                var input = Console.ReadLine();
                if (input == "stop")
                    break;
                else
                    myArray[i] = input;
            }

            Console.WriteLine("Vivod masiva");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            return myArray;
        }
        public static string ConvertToHtml(string[] myArray) 
        {
            string strOutPut = string.Empty;
            foreach (var item in myArray)
            {
                strOutPut += $"<li>{item}</li>";
            }
            string strOutputResult = $"Project<ul>{strOutPut}</ul>";
            Console.WriteLine(strOutputResult);
            return strOutputResult;
        }
        public static void WriteToFile(string strOutputResult)
        {
            StreamWriter sw = new StreamWriter(@"C:\roma\ListProject.html");
            sw.WriteLine(strOutputResult);
            sw.Close();
        }
    }

}