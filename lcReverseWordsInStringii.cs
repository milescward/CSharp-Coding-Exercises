namespace CSharp_Practice
{
    public class lcReverseWordsInStringii
    {
        public static void ReverseWords(char[] s)
        {
            int l = s.Length - 1;
            int r = l;
            s = Reverse(s, 0, s.Length - 1);
            while (l > 0)
            {
                while (s[l] != ' ' && l > 0)
                {
                    l--;
                }
                s = Reverse(s, l + 1, r);
                l = l - 1;
                r = l;
            }
        }

        public static char[] Reverse(char[] s, int l, int r)
        {
            if (l == 1)
                l = 0;
            char temp;
            while (l < r )
            {
                temp = s[l];
                s[l] = s[r];
                s[r] = temp;
                l++;
                r--;
            }
            return s;
        }
    }
}