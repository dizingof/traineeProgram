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
            //var afterConvert = ConvertToHtml(enteredArray);
            //WriteToFile(afterConvert);
            var afterConvert = ConvertToHtmlTable(enteredArray);
            WriteToFile(afterConvert);
            Console.ReadKey();
        }


        public static string[] VvodMasiva()
        {
            try
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

                //for (int i = 0; i < myArray.Length; i++)
                //{


                //        if (myArray[i] == null)
                //            {
                //                 myArray[i].Remove(0, i);

                //            }

                //    }

                Console.WriteLine("Vivod masiva");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }
                return myArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erorr: {ex.ToString()}");
                return null;
            }

        }
        public static string ConvertToHtml(string[] myArray)
        {
            try
            {
                string strOutPut = string.Empty;
                foreach (var item in myArray)
                {
                    strOutPut += $"<li>Project:</li><li>{item}</li>";
                }
                string strOutputResult = $"<ul>{strOutPut}</ul>";
                Console.WriteLine(strOutputResult);
                return strOutputResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erorr: {ex.ToString()}");
                return null;
            }
        }
        public static string ConvertToHtmlTable(string[] myArray)
        {
            try
            {
                string strOutPut = string.Empty;
                foreach (var item in myArray)
                {
                    strOutPut += $"<li>Project:</li><li>{item}</li>";
                }
                string strOutputResultTable = $"<table border=\"1\"><tr><th>Project</th></tr><tr><td>{strOutPut}</td></tr><tr><td>Ячейка 3</td></tr><tr><td>Ячейка 3</td></tr></table>";
                    
                    Console.WriteLine(strOutputResultTable);
                return strOutputResultTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erorr: {ex.ToString()}");
                return null;
            }
        }
        public static void WriteToFile(string strOutputResult)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\roma\ListProject.html");
                sw.WriteLine(strOutputResult);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erorr: {ex.ToString()}");

            }
        }
    }

}