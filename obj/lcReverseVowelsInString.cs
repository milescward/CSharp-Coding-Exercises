using System.Collections.Generic;

namespace CSharp_Practice.obj
{
    //Write a function that takes a string as input 
    //and reverse only the vowels of a string.
    //Vowels dont include y
    public class lcReverseVowelsInString
    {
        public string ReverseVowels(string s) 
        {
            char[] charr = s.ToCharArray();
            var vowels = new List<char>{'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};
            int lp = 0;
            int rp = s.Length - 1;

            while (lp < rp)
            {
                while(!vowels.Contains(charr[lp]) && lp < rp)
                {
                    lp++;
                }

                while (!vowels.Contains(charr[rp]) && lp < rp)
                {
                    rp--;
                }
                char temp = charr[lp];
                charr[lp] = charr[rp];
                charr[rp] = temp;
                lp++;
                rp--;
            }
            return string.Join("", charr);
        }

        public void Swap(char[] arr, int l, int r)
        {
            char temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;
        }
    }
}