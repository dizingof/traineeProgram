using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolekcii
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<List<int>>();
            MyClass<int> insatnce1 = new MyClass<int>();
            insatnce1.field1 = 1;
            MyClass<string> insatnce2 = new MyClass<string>();
            insatnce2.field1 = "word";





        }
    }

 


    class MyClass <List<T>>
    {
        public List<T> field1 { get; set; }
    }

     
}
