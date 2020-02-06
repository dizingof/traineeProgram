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


            string firstResult = convertStringToHtml("Project: P1, Project: P2", ", Project:");
            string secondResult = convertStringToHtml(firstResult, "Project: ");
            var resultAfterSplit = secondResult.Split(' ');
            string strOutPut = "";
            foreach (var item in resultAfterSplit)
            {
                strOutPut = strOutPut + $"<li>{item}</li>";
            }
            string strOutputResult = "Project" + "<ul>" + strOutPut + "</ul>";
            Console.WriteLine(strOutputResult);
            Console.ReadKey();

        }
        public static string convertStringToHtml(string inputStr, string removeStr)
        {
            int n = inputStr.IndexOf(removeStr);
            var inputStrAfterRemove = inputStr.Remove(n, removeStr.Length);
            return inputStrAfterRemove;
        }


    }
}
