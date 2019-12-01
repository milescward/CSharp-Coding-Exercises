using System;
using System.Collections.Generic;

namespace CSharp_Practice.DataStructures
{
    public class SinglyLinkedList
    {
        private Node head { get; set; }

        public void Add(Node node)
        {
            node.Next = head;
            head = node;
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