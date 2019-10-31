using System;
using System.Linq;

namespace Practice
{
    /*Reverse a signly linked list by declaring new
    Node and Linked List classes */

    class Node
    {
        public int Value;
        public Node Next;

        public Node(int someValue)
        {
            Value = someValue;
        }
    }

    class SinglyLinkedList
    {
        public Node Head;

        public override string ToString()
        {
            string returnedResult = "";
            Node pointer = Head;

            while (pointer != null)
            {
                returnedResult += " " + pointer.Value;
                pointer = pointer.Next;
            }
        return returnedResult;
        }

        public void AddFront(int val)
        {
            //create a new node
            Node newNode = new Node(val);
            //link the new node to the head
            newNode.Next = Head;
            //move the head
            Head = newNode;
        }

        public void Reverse()
        {
            Node pointer = Head;
            Head = null;
            while (pointer != null)
            {
                AddFront(pointer.Value);
                pointer = pointer.Next;
            }
        }

        public void Reverse2()
        {
            if (Head == null || Head.Next == null)
            {
                return; //if the list is empty or contains just one node
            }
            else
            {
                Node pointer = Head.Next;
                Node pointer2 = Head.Next.Next;

                Head.Next = null;
                while (true)
                {
                    pointer.Next = Head;
                    Head = pointer;
                    pointer = pointer2;
                    if (pointer2 != null)
                    {
                        pointer2 = pointer2.Next;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public void Reverse3()
        {
            if (Head == null || Head.Next == null)
            {
                return; //if the list is empty or contains just one node
            }
            else
            {
                Node pointer = Head.Next;
                Node pointer2 = Head.Next.Next;

                Head.Next = null;
                do
                {
                    pointer.Next = Head;
                    Head = pointer;

                    pointer = pointer2;
                    if (pointer2 != null)
                    {
                        pointer2 = pointer2.Next;
                    }
                    else
                    {
                        break;
                    }
                } while (true);
            }
        }
    }
}