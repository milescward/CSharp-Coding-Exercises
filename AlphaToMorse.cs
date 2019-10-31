using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Practice
{
    public class AlphaToMorse
    {
        /*International Morse Code defines a standard 
        encoding where each letter is mapped to a 
        series of dots and dashes, as follows: "a" 
        maps to ".-", "b" maps to "-...", "c" maps 
        to "-.-.", and so on. */

        //faster than 80% of submissions

        /* Given a list of words, each word can be written 
        as a concatenation of the Morse code of each letter. 
        For example, "cba" can be written as "-.-..--...", 
        (which is the concatenation "-.-." + "-..." + ".-").
         We'll call such a concatenation, the transformation 
         of a word.

        Return the number of different transformations among 
        all words we have. */

        public int UniqueMorseRepresentation(string[] words)
        {
            HashSet<string> hash = new HashSet<string>();
            Dictionary<char, string> MCDict = GetMCodeDictionary();
            for (int i = 0; i < words.Length; i++)
            {
                List<string> mCodeBuilder = new List<string>();
                string word = words[i];
                foreach (var item in word)
                {
                    mCodeBuilder.Add(MCDict[item]);
                }
                string wordCode = string.Join("", mCodeBuilder);
                hash.Add(wordCode);
                mCodeBuilder.Clear();
            }
            return hash.Count;
        }

        private static Dictionary<char, string> GetMCodeDictionary()
        {
            //char c = 'A';
            List<string> mCode = new List<string>() { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] c = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Dictionary<char, string> myDict = new Dictionary<char, string>();
            for (int i = 0; i < c.Length; i++)
            {
                myDict.Add(c[i], mCode[i]);
            }
            return myDict;
        }
    }
}