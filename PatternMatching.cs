using System.Collections.Generic;
using System.Linq;

namespace CSharp_Practice
{
    public class PatternMatching
    {
        static bool SamePattern(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            string s1Pattern = BuildPattern(s1);
            string s2Pattern = BuildPattern(s2);
            for (int i = 0; i < s1Pattern.Length; i++)
            {
                if (s1Pattern[i] != s2Pattern[i])
                {
                    return false;
                }
            }
            return true;
        }

        private static string BuildPattern(string s1)
        {
            Dictionary<char, int> myDict1 = new Dictionary<char, int>();
            int letterNumber = 1;
            string pattern = "";
            for (int i = 0; i < s1.Length; i++)
            {
                if (myDict1.Keys.Contains(s1[i]))
                {
                    continue;
                }
                else
                {
                    myDict1.Add(s1[i], letterNumber);
                    letterNumber++;
                }
            }
            foreach (var c in s1)
            {
                int patternNumber = myDict1[c];
                pattern = pattern + patternNumber.ToString();
            }
            return pattern;
        }
    }
}