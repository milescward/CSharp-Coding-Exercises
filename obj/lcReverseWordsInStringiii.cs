using System;

namespace CSharp_Practice.obj
{
    // Given a string, you need to reverse the order of characters 
    // in each word within a sentence while still preserving 
    // whitespace and initial word order.
    public class lcReverseWordsInStringiii
    {
        public string ReverseWords(string s) 
    {
        if(string.IsNullOrEmpty(s))
            return "";
        char[] arr = s.ToCharArray();
        int lp = 0;
        int rp = 0;
        while (rp != arr.Length - 1)
        {
            while (!char.IsWhiteSpace(arr[rp]) && rp != arr.Length -1)
            {
                rp++;
            }
            if(rp == arr.Length-1)
                Array.Reverse(arr, lp, (rp+1) - lp);
            else
            {
                Array.Reverse(arr, lp, (rp-lp));
                rp++;
                lp = rp;
            }
        }
        return string.Join("", arr);
    }
    }
}