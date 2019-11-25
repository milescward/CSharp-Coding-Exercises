using System.Collections.Generic;

namespace CSharp_Practice.obj
{
    // Given a string S, remove the vowels 'a', 'e', 
    //'i', 'o', and 'u' from it, and return the new string.

    //Runtime faster than 95%
    //Space less than 100%
    public class lcRemoveVowelsFromString
    {
        public string RemoveVowels(string S) 
        {
            List<char> charList = new List<char>();
            var vowels = new List<char>{'a', 'e', 'i', 'o', 'u'};
            for(int i = 0; i < S.Length; i++)
            {
                if(!vowels.Contains(S[i]))
                    charList.Add(S[i]);
            }
            return string.Join("", charList);
        }
    }
}