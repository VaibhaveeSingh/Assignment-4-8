using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment4_8
{
    class Assignment1
    {
        static void Main() 
        {
            LinkedList<string> lList= new LinkedList<string>(new string[]{"quick","fox","the","lazy"});
            //the quick brown fox jumps over the lazy fox
            lList.AddFirst("the");
            lList.AddAfter(lList.First.Next, "brown");
            LinkedListNode<string> node1 = lList.FindLast("the");
            lList.AddBefore(node1, "over");
            LinkedListNode<string> node = lList.Find("over");
            lList.AddBefore(node, "jumps");
            lList.AddLast("fox");
            

            

            foreach (var item in lList)
            {
                Console.WriteLine(item);

            }

          

        }
    }
}
