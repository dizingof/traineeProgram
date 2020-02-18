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
            ChooseOptionOfOutput(enteredArray);
            Console.ReadKey();
        }


        public static string[,] VvodMasiva()
        {
            try
            {
                Console.Write("vvedite kolichestvo proectov:\t");
                int elementsCountI = int.Parse(Console.ReadLine());

                int elementsCountJ = 3;
                string[,] myArray = new string[elementsCountI, elementsCountJ];

                for (int i = 0; i < elementsCountI; i++)
                {
                    Console.WriteLine("VVedite nazvanie minZarabotok maxZarabotok");
                    for (int j = 0; j < elementsCountJ; j++)
                    {

                        myArray[i, j] = Console.ReadLine();
                        //Console.ReadLine(mat[i, j]);
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
                return myArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erorr: {ex.ToString()}");
                return null;
            }

        }
        public static void ChooseOptionOfOutput(string[,] enteredArray)
        {
            Console.WriteLine("Vvedite 1 - dlya vivoda v formate (List), 2 - dlya vivoda v formate (Table), 3 - dlya vivoda v formate (Json)");
            string numberChoiseOption = Console.ReadLine();
            switch (numberChoiseOption)
            {
                case "1":
                    var afterConvert = ConvertToHtml(enteredArray);
                    WriteToFile(afterConvert);
                    break;
                case "2":
                    var afterConvert1 = ConvertToHtmlTable(enteredArray);
                    WriteToFile(afterConvert1);
                    break;

                default:
                    Console.WriteLine("Takogo varianta netu");
                    break;
            }

        }

        public static string ConvertToHtml(string[,] myArray)
        {
            try
            {
                string strOutPut = string.Empty;
                string strOutPut1 = string.Empty;
                //foreach (var item in myArray)
                //{
                //    strOutPut += $"<li>Project:</li><li>{item}</li>";
                //}
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
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
        public static string ConvertToHtmlTable(string[,] myArray)
        {
            try
            {
                string strOutPut = string.Empty;
                string strOutPut1 = string.Empty;
                foreach (var item in myArray)
                {
                    strOutPut += $"<tr><td>{item}</td></tr>";
                    foreach (var item1 in myArray)
                    {
                        strOutPut1 = $"<table border=\"1\"><tr><th>Project</th></tr>{strOutPut}</table>";
                    }
                }
                string strOutputResult = strOutPut1;


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