using System.Linq;

namespace Practice
{
    /* Given a string, determine if it is a palindrome, 
    considering only alphanumeric characters and ignoring 
    cases.

    Note: For the purpose of this problem, we define 
    empty string as valid palindrome.
     */
    public class lcValidPalindrome
    {
        private static bool ValidPalindrome(string s)
        {
            var arr1 = s.Where(c => (!char.IsPunctuation(c)) &&
                                     !char.IsWhiteSpace(c) &&
                                     !char.IsSymbol(c)).ToArray();
            if (string.Join("", arr1).ToLower() == string.Join("", arr1.Reverse()).ToLower())
            {
                return true;
            }
            return false;
        }

        public bool IsPalindrome(string s) 
        {
            s = s.ToLower();
            int r = s.Length - 1;
            for(int l = 0; l < r;)
            {
                if(!char.IsLetterOrDigit(s[l])) 
                    l++;
                else if(!char.IsLetterOrDigit(s[r]))
                    r--;
                else if(s[l++] != s[r--])
                    return false;
            }
            return true;
        }
    }
}