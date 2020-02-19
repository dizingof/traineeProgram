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

            var enteredArray = VvodMasiva(out int dlinnaMasivaI);
            ChooseOptionOfOutput(enteredArray, dlinnaMasivaI);
            Console.ReadKey();
        }


        public static string[,] VvodMasiva(out int dlinnaMasivaI)
        {

            Console.Write("vvedite kolichestvo proectov:\t");
            int elementsCountI = int.Parse(Console.ReadLine());
            dlinnaMasivaI = elementsCountI;
            int elementsCountJ = 13;
            string[,] myArray = new string[elementsCountI, elementsCountJ];

            for (int i = 0; i < elementsCountI; i++)
            {
                Console.WriteLine("VVedite nazvanie proekta");
                for (int j = 0; j < elementsCountJ; j++)
                {
                    myArray[i, j] = Console.ReadLine();
                    if (j < 12)
                    {
                        Console.WriteLine($"Month {j + 1}");
                    }
                    
                }
            }
            Console.WriteLine("Nazvanie proekta      MinZarabotok     MaxZarabotok");
            for (int i = 0; i < elementsCountI; i++)
            {
                Console.WriteLine("\n");

                for (int j = 0; j < elementsCountJ; j++)
                {

                    Console.Write(myArray[i, j] + "\t" + "\t" + "\t");

                }
                Console.WriteLine("\n");
            }
            return (myArray);



        }
        public static void ChooseOptionOfOutput(string[,] enteredArray, int dlinnaMasivaI)
        {
            Console.WriteLine("Vvedite 1 - dlya vivoda v formate (List), 2 - dlya vivoda v formate (Table), 3 - dlya vivoda v formate (Json)");
            string numberChoiseOption = Console.ReadLine();
            switch (numberChoiseOption)
            {
                case "1":
                    var afterConvert = ConvertToHtml(enteredArray, dlinnaMasivaI);
                    WriteToFile(afterConvert);
                    break;
                case "2":
                    var afterConvert1 = ConvertToHtmlTable(enteredArray, dlinnaMasivaI);
                    WriteToFile(afterConvert1);
                    break;

                default:
                    Console.WriteLine("Takogo varianta netu");
                    break;
            }

        }

        public static string ConvertToHtml(string[,] myArray, int elementsCountI)
        {
            try
            {
                string strOutPut = string.Empty;
                string strOutPut1 = string.Empty;


                for (int i = 0; i < elementsCountI; i++)
                {
                    strOutPut = null;
                    for (int j = 0; j < 13; j++)
                    {
                        strOutPut += $"<li>{myArray[i, j]}</li>";
                    }
                    strOutPut1 += $"<li>Project:</li>" + strOutPut;
                }


                string strOutputResult = $"<ul>{strOutPut1}</ul>";
                Console.WriteLine(strOutputResult);
                return strOutputResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erorr: {ex.ToString()}");
                return null;
            }
        }
        public static string ConvertToHtmlTable(string[,] myArray, int elementsCountI)
        {
            try
            {
                
                string strOutPut = string.Empty;
                string strOutPut1 = string.Empty;
                string strOutPut2 = string.Empty;
                string strOutPut3 = string.Empty;
                for (int i = 0; i < elementsCountI; i++)
                {
                    strOutPut = null;
                    for (int j = 0; j < 13; j++)
                    {
                        strOutPut += $"<td>{myArray[i, j]}</td>";
                    }
                    strOutPut1 += $"<tr>{strOutPut}</tr>";
                }
                strOutPut2 = $"<td>Project Name</td><td>January</td><td>February</td><td>March</td><td>April</td><td>May</td><td>June</td><td>July</td><td>August</td><td>September</td><td>October</td><td>November</td><td>December</td>{strOutPut1}</table>";
                strOutPut3 = $"<table border=\"1\">{strOutPut2}</table>";
                string strOutputResult = strOutPut3;
                Console.WriteLine(strOutputResult);
                return strOutputResult;
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