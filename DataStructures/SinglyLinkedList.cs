using System;

namespace CSharp_Practice.DataStructures
{
    public class SinglyLinkedList
    {
        public Node Head { get; set; }
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