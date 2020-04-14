using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    class Service : IContract
    {
        public void Say(string input)
        {
            Console.WriteLine(input);
        }
    }
}
