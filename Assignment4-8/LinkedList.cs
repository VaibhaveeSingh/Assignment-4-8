using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment4_8
{
    class LinkedList
    {
        static void Main() 
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.AddLast(10);
            myLinkedList.AddFirst(13);
            myLinkedList.AddLast(11);
            myLinkedList.AddFirst(3);
            myLinkedList.AddLast(1);
            myLinkedList.AddFirst(413);

            Console.WriteLine("initial Linked list");
            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("count of item in linked list is : {0}" , myLinkedList.Count);
            Console.WriteLine("------------------------------------------------------------");
            var x = myLinkedList.First.Value;
            Console.WriteLine("first item : {0}",x);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("last item : {0}", myLinkedList.Last.Value);
            Console.WriteLine("------------------------------------------------------------");
            var node = myLinkedList.AddLast(20);
            myLinkedList.AddAfter(node,12);
            myLinkedList.AddBefore(node, 123);
            Console.WriteLine("adding 123 before and 12 after 20");
            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("using contains to check if the iteam is there ");



            Console.WriteLine("4 is in Linked List :{0}", myLinkedList.Contains(4));
            Console.WriteLine("------------------------------------------------------------");

           
            Console.WriteLine("Reversing my Linked list");
            myLinkedList.Reverse();
            foreach (var j in myLinkedList)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("------------------------------------------------------------");

            myLinkedList.Remove(20);
            Console.WriteLine("removing 20 from my linked list");
            foreach (var k in myLinkedList)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("------------------------------------------------------------");

            var a =myLinkedList.Find(1);
            Console.WriteLine("find{0}",a);


            Console.WriteLine("clear my array");
            myLinkedList.Clear();
            foreach (var l in myLinkedList)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
