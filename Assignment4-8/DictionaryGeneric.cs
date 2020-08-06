using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment4_8
{
    class DictionaryGeneric
    {
        static void Main() 
        {
            Dictionary<char, string> myDictionary = new Dictionary<char, string>();
            myDictionary.Add('A', "Able");
            myDictionary.Add('L', "Lana");
            myDictionary.Add('T', "Taylor");
            myDictionary.Add('X', "Xess");

            Console.WriteLine("my dictionary");

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("----------------------------------------------------------------\nContainskey\n ");

            Console.WriteLine(myDictionary.ContainsKey('L'));
            Console.WriteLine("----------------------------------------------------------------\nContainsvalue\n ");

            Console.WriteLine(myDictionary.ContainsValue("Tess"));

            Console.WriteLine("----------------------------------------------------------------\nkey property\n");

            foreach (var k in myDictionary.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("----------------------------------------------------------------\nvalue property\n");

            foreach (var v in myDictionary.Values)
            {
                Console.WriteLine(v);
            }

            Console.Read();


        }
    }
}
