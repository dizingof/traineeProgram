using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "Project: P1, Project: P2";
            string removeStr = ", Project:";
            int n = inputStr.IndexOf(removeStr);
            inputStr = inputStr.Remove(n, removeStr.Length);
            string removeStr2 = "Project: ";
            int n2 = inputStr.IndexOf(removeStr2);
            inputStr = inputStr.Remove(n2, removeStr2.Length);


            var splitStr = inputStr.Split(' ');
            Console.Write("Project");
            Console.Write("<ul>");
            foreach (string c in splitStr)
            {
                Console.Write($"<li>{c}</li>");
            }
            Console.Write("</ul>");
            Console.ReadKey();
        }
    }
}
