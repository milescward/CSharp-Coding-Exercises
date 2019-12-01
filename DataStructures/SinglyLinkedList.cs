using System;
using System.Collections.Generic;

namespace CSharp_Practice.DataStructures
{
    public class SinglyLinkedList
    {
        private Node Head { get; set; }
        public int Count { get; private set; }

        public void Add(Node node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            Count++;
        }

        // Deletes the first occurance of a target in the linked list
        public void Delete(object target)
        {
            if (Head.Data == target)
            {
                Head = Head.Next;
            }

            Node iterator = Head;
            while(iterator != null)
            {
                if (iterator.Next.Data == target)
                {
                    iterator.Next = iterator.Next.Next;
                    Count--;
                }
            }
        }

        public void Display()
        {
            Node iterator = Head;
            while (iterator != null)
            {
                Console.WriteLine(iterator.Data);
                iterator = iterator.Next;
            }
        }
    }

    public class Node
    {
        public Node Next { get; set; } 
        public Object Data { get; set; }
        public Node(Object data)
        {
            this.Data = data;
        }
    }
}