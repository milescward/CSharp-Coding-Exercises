using System;
using CSharp_Practice.DataStructures;

namespace CSharp_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myList = new SinglyLinkedList();
            myList.Add(new Node(1));
            myList.Add(new Node(2));
            myList.Add(new Node(3));
            myList.Add(new Node(4));
            myList.Add(new Node(5));

            myList.Display();
        }
    }
}