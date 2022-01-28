using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack(); // creating object for a class
            linkedListStack.Enqueue(56);    // adding values to the Queue
            linkedListStack.Enqueue(30);
            linkedListStack.Enqueue(70);
            linkedListStack.Display();
            linkedListStack.Dequeue();
        }
    }
}
