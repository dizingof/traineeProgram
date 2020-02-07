using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringToHtml
{
    class stringToHtml
    {
        static void Main(string[] args)
        {
            string resultEnterData = EnterData();
            var finish = BuildOutputResult(resultEnterData);
            Console.WriteLine(finish);
            Console.ReadKey();

        }
        public static string EnterData()
        {
            Console.WriteLine("Vvedite dannie v formate: \"Project: P1, Project: P2\"");
            string enteredData = Console.ReadLine();
            return enteredData;
        }
        public static string BuildOutputResult(string resultEnterData)
        {
            string firstResult = RemoveWordFromEnteredData(resultEnterData, ", Project:");
            string secondResult = RemoveWordFromEnteredData(firstResult, "Project: ");
            var resultAfterSplit = secondResult.Split(' ');
            string strOutPut = string.Empty;
            foreach (var item in resultAfterSplit)
            {
                 strOutPut += $"<li>{item}</li>";
            }
            string strOutputResult = $"Project<ul>{strOutPut}</ul>";
            return strOutputResult;
        }
        public static string RemoveWordFromEnteredData(string inputStr, string removeStr)
        {
            int number = inputStr.IndexOf(removeStr);
            var inputStrAfterRemove = inputStr.Remove(number, removeStr.Length);
            return inputStrAfterRemove;
        }
        
    }
}
