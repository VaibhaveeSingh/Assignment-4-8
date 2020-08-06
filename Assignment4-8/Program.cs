using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> mySL = new SortedList<int, string>() ;
            mySL.Add(1, "one");
            mySL.Add(2, "two");
            mySL.Add(3, "three");
            mySL.Add(4, "four");
            mySL.Add(5, "five");
            Console.WriteLine("my sorted list");
            foreach (var a in mySL)
            {
                Console.WriteLine(a);
            }


            Console.WriteLine("----------------------------------------------------------------\nContainskey\n ");

            Console.WriteLine(mySL.ContainsKey(2));
            Console.WriteLine("----------------------------------------------------------------\nContainsvalue\n ");

            Console.WriteLine(mySL.ContainsValue("one"));
                       
            Console.WriteLine("----------------------------------------------------------------\nkey property\n");

            foreach (var k in mySL.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("----------------------------------------------------------------\nvalue property\n");

            foreach (var v in mySL.Values)
            {
                Console.WriteLine(v);
            }

            Console.Read();

        }
    }
}
