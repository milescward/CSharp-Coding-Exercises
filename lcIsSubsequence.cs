namespace CSharp_Practice
{
    /* Given a string s and a string t, check if s 
    is subsequence of t.

    You may assume that there is only lower case 
    English letters in both s and t. t is potentially 
    a very long (length ~= 500,000) string, and s is 
    a short string (<=100).
    */

    // Faster than %95
    // Less than %100 of submissions on LeetCode
    public class lcIsSubsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            int slen = s.Length;
            int tlen = t.Length;
            int ps = 0;
            int pt = 0;
            while (ps < slen && pt < tlen)
            {
                if(s[ps] != t[pt])
                    pt++;
                else
                {
                    ps++;
                    pt++;
                }
            }
            if (ps == slen)
                return true;
            return false;
        }
    }
}