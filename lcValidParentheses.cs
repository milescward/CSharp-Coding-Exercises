using System.Collections.Generic;

namespace CSharp_Practice
{
    public class lcValidParentheses
    {
        public bool IsValid(string s) 
        {
            if (s == "")
            {
                return true;
            }
            Dictionary<char, char> d = new Dictionary<char, char> 
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'}
            };
            Stack<char> myStack = new Stack<char>();
            foreach (var item in s)
            {
                if (d.ContainsKey(item))
                {
                    myStack.Push(item);
                }
                else if (d.ContainsValue(item))
                {
                    if (myStack.Count == 0)
                    {
                        return false;
                    }
                    else if (d[myStack.Peek()] == item)
                    {
                        myStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (myStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}