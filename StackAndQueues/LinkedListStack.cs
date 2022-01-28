﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    class LinkedListStack
    {
        public Node top;
        public void Push(int newData)
        {
            // creating a link between newnode and where top is pointing
            Node new_node = new Node(newData);
            if (this.top != null)
            {
                new_node.next = this.top; // newnode will hold the address of top element
            }
            this.top = new_node; //top will point to new element
            Console.WriteLine(" New node {0} is added ", new_node.data);
        }
        public void Display() //printing the values till temp point towards null
        {
            Console.WriteLine("Displaying Names");
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("no values to display ,Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" Values in the stack : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}