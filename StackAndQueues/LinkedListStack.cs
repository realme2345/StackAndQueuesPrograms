using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    class LinkedListStack
    {
        public Node head;
        public void Enqueue(int newData)
        {
            // creating a link between newnode and where head is pointing
            Node new_node = new Node(newData);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("inserted into list" + " " + new_node.data);
        }
        public void Display() //printing the values till temp point towards null
        {
            Console.WriteLine("Displaying Names");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("no values to display ,Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" Values in the Queue : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
