using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        private readonly int kolichestvoMesyacev = 4;
        static void Main(string[] args)
        {
            ZapuskVsehMetodov();
            Console.ReadKey();
        }

        public static void ZapuskVsehMetodov()
        {

            var enteredArray = VvodMasiva(out int dlinnaMasivaI);
          
            var newArr = ResizeConvertOldArrayToInt(enteredArray, dlinnaMasivaI);
            SearchMinElementInNewArr(newArr, dlinnaMasivaI);
            SearchMaxElementInNewArr(newArr, dlinnaMasivaI);
            ChooseOptionOfOutput(enteredArray, dlinnaMasivaI);
        }
        public static string[,] VvodMasiva(out int dlinnaMasivaI)
        {

            Console.Write("vvedite kolichestvo proectov:\t");
            int elementsCountI = int.Parse(Console.ReadLine());
            dlinnaMasivaI = elementsCountI;
            int elementsCountJ = 4;
            string[,] myArray = new string[elementsCountI, elementsCountJ];

            for (int i = 0; i < elementsCountI; i++)
            {
                Console.WriteLine("VVedite nazvanie proekta");
                for (int j = 0; j < elementsCountJ; j++)
                {
                    myArray[i, j] = Console.ReadLine();
                    if (j < 3)
                    {
                        Console.WriteLine($"Month {j + 1}");
                    }

                }
            }
            Console.WriteLine("Nazvanie proekta      Month1     Month2      Month3");
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
        public static void ChooseOptionOfOutput(string[,] enteredArray, int dlinnaMasivaI)
        {
            Console.WriteLine();
            Console.WriteLine("Vvedite 1 - dlya vivoda v formate (List), 2 - dlya vivoda v formate (Table), 3 - dlya vivoda v formate (Json)");
            string numberChoiseOption = Console.ReadLine();
            switch (numberChoiseOption)
            {
                case "1":
                    var afterConvert = ConvertToHtml(enteredArray, dlinnaMasivaI);
                    Console.WriteLine(afterConvert.Length);
                    WriteToFile(afterConvert);
                    Stop();
                   
                    break;
                case "2":
                    var afterConvert1 = ConvertToHtmlTable(enteredArray, dlinnaMasivaI);
                    WriteToFile(afterConvert1);
                    Stop();
                    
                    break;
                case "3":
                    
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
                //throw new Exception("text oshibki");
                string strOutPut = string.Empty;
                string strOutPut1 = string.Empty;


                for (int i = 0; i < elementsCountI; i++)
                {
                    strOutPut = string.Empty;
                    Console.WriteLine(strOutPut.Length);
                    for (int j = 0; j < 4; j++)
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
                Console.WriteLine($"erorr: {ex.Message}");
                return string.Empty;
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
                    for (int j = 0; j < 4; j++)
                    {
                        strOutPut += $"<td>{myArray[i, j]}</td>";
                    }
                    strOutPut1 += $"<tr>{strOutPut}</tr>";
                }
                strOutPut2 = $"<td>Project Name</td><td>Month1</td><td>Month2</td><td>Month3</td>{strOutPut1}</table>";
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

        public static int[,] ResizeConvertOldArrayToInt(string[,] myArray, int elementsCountI)
        {
            string strOutPut = string.Empty;
            string strOutPut1 = string.Empty;


            var newArr = new int[elementsCountI, 3];
            for (int i = 0; i < elementsCountI; i++)
            {
                Console.WriteLine("\n");
                for (var j = 0; j < 3; j++)
                {
                    newArr[i, j] = int.Parse(myArray[i, j + 1]);
                    Console.Write(newArr[i, j]);

                }

            }
            return (newArr);
        }
        public static void SearchMaxElementInNewArr(int[,] newArr, int elementsCountI)
        {
            int max;

            for (int i = 0; i < elementsCountI; i++)
            {
                Console.WriteLine("\n");
                max = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (newArr[i, j] > max)
                    {
                        max = newArr[i, j];
                    }
                }
                Console.Write($"MAX = {max}");

            }

        }
        public static void SearchMinElementInNewArr(int[,] newArr, int elementsCountI)
        {
            Console.WriteLine("\n");
            int min = -1;

            for (int i = 0; i < elementsCountI; i++)
            {
                Console.WriteLine("\n");
               
                for (int j = 0; j < 3; j++)
                {
                    if (min== - 1 || newArr[i, j] < min)
                    {
                        
                        min = newArr[i, j];
                    }
                }
                Console.WriteLine($"MIN =  {min}");
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
        public static void Stop()
        {
            Console.WriteLine("hotite prodolgit nagmite \"y\" esli hotite viiti nagmite \"q\"?");
            var sostoyanie = Console.ReadLine();
            if (sostoyanie == "y")
            {
                ZapuskVsehMetodov();

            }
            else if (sostoyanie == "q")
            {
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("Vvedite Korektnii varint");
                Stop();
            }
        }
    }

}