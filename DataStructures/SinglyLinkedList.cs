using System;
using System.Collections.Generic;

namespace CSharp_Practice.DataStructures
{
    public class SinglyLinkedList
    {
        public Node First 
        {
            get
            {
                return stack.Peek();
            }
        }
        private Stack<Node> stack;

        public void Add(Node node)
        {
            node.Next = First;
            stack.Push(node);
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