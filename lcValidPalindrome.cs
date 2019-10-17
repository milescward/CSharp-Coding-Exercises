using System.Linq;

namespace Practice
{
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
    }
}