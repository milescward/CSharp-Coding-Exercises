using System.Text.RegularExpressions;

namespace CSharp_Practice
{
    public class ReverseWordsInString
    {
        public static string ReverseWords(string s) 
        {
            if(string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                return s.Trim();
            }              
            s = Regex.Replace(s,@"\s+"," ");
            s = s.Trim();
            int length = s.Length;
            char[] sArr = s.ToCharArray();
            int p = 0;
            int b = 0;
            for(int i = 0; i < length/2; i++)
            {
                char temp = sArr[i];
                sArr[i] = sArr[(sArr.Length-1)-i];
                sArr[(sArr.Length-1)-i] = temp;
            }
            while (p != length-1)
            {
                while ((!char.IsWhiteSpace(sArr[p])) && (p != length-1))
                {
                    p++;
                }
                if (p == length-1)
                {
                    Array.Reverse(sArr, b, ((p+1)-b));
                }
                else
                {
                    Array.Reverse(sArr, b, (p-b));
                    p++;
                    b = p;
                }
            }
            return string.Join("", sArr);
        }
    }
}