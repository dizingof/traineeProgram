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
            string removeStr = ", Project";
            int n = inputStr.IndexOf(removeStr);
            inputStr = inputStr.Remove(n, removeStr.Length);
            var splitStr = inputStr.Split(':');

            foreach (var c in splitStr)
            {
                Console.WriteLine(c);
            }
            //Console.Write("<ul>");
            //foreach (string c in splitStr)
            //{
            //    Console.WriteLine($"<li>{c}</li>");
            //}
            //Console.Write("<ul>");
            Console.ReadKey();
        }
    }
}
