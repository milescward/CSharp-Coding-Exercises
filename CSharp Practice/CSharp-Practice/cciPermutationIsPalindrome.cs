using System;
using System.Collections.Generic;

namespace Practice
{
    public class cciPermutationIsPalindrome
    {
        public bool PermIsPal(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var letter in s)
            {
                if (dict.ContainsKey(letter))
                {
                    dict[letter] += 1;
                }
                else
                {
                    dict.Add(letter, 1);
                }
            }

            int count = 0;
            foreach (var value in dict.Values)
            {
                if (value % 2 != 0)
                {
                    count++;
                    if (count > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
