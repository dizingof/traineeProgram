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
            var finish = buildStrOutputResult();
            Console.WriteLine(finish);
            Console.ReadKey();

        }
       
        public static string buildStrOutputResult()
        {
            string firstResult = convertStringToHtml("Project: P1, Project: P2", ", Project:");
            string secondResult = convertStringToHtml(firstResult, "Project: ");
            var resultAfterSplit = secondResult.Split(' ');
            string strOutPut = string.Empty;
            foreach (var item in resultAfterSplit)
            {
                 strOutPut += $"<li>{item}</li>";
            }
            string strOutputResult = $"Project<ul>{strOutPut}</ul>";
            return strOutputResult;
        }
        public static string convertStringToHtml(string inputStr, string removeStr)
        {
            int number = inputStr.IndexOf(removeStr);
            var inputStrAfterRemove = inputStr.Remove(number, removeStr.Length);
            return inputStrAfterRemove;
        }
    }
}
