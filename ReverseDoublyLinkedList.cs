using System.Collections.Generic;

namespace Practice
{
    public class ReverseDoublyLinkedList
    {
        static LinkedList<int> ReverseLinkedList(LinkedList<int> lst)
        {
            LinkedList<int> newLl = new LinkedList<int>();
            LinkedListNode<int> node = lst.First;
            while (node != null)
            {
                newLl.AddFirst(node.Value);
                node = node.Next;
            }
            return newLl;
        }
    }
}