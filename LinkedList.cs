using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.Next!= null)
                {
                    temp = temp.Next;   
                }
                temp.Next=node;
            }
            Console.WriteLine("{0} is inserted into the lined list", +data);

        }
       

    }
}
