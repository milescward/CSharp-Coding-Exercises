using System;
using System.Collections.Generic;

namespace CSharp_Practice
{
    public class lcLongestSubstringWithUniqueCharacters
    {
        //Given a string, find the length of the longest 
        //substring without repeating characters.
        public int LengthOfLongestSubstring(string s) 
        {
            if(string.IsNullOrEmpty(s))
                return 0;
            int max = 0, i = 0, j = 0;
            var set = new HashSet<char>();
            int n = s.Length;
            while(j < n)
            {
                if(!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    max = Math.Max(max, j-i);
                }
                else
                    set.Remove(s[i++]);
            }
            return max;
        }

        public int LengthOfLongestSubstring2(string s) 
        {
            if(s.Length == 0 || string.IsNullOrEmpty(s))
                return 0;
            int max = 0;
            int i = 0;
            int j = 0;
            var d = new Dictionary<char, int>();
            int n = s.Length;
            while(j < n)
            {
                if(!d.ContainsKey(s[j]))
                {
                    d[s[j++]] = j;
                    max = Math.Max(max, j-i);
                }
                else
                {
                    i = ++d[s[j]];
                    d.Remove(s[j]);
                }
            }
            return max;
        }
    }
}