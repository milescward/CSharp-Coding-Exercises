using System;

namespace CSharp_Practice
{
    public class ReverseInteger
    {
        public int Reverse(int x) 
    { 
        try
            {
                bool isNegative = false;
                if (x < 0)
                {
                    isNegative = true;
                    x *= -1;
                }

                char[] charArray = x.ToString().ToCharArray();
                Array.Reverse(charArray);
                string str = "";
                Array.ForEach(charArray, p => str += p.ToString());
                int reverseNum = int.Parse(str);

                if (isNegative == true) {
                    reverseNum = reverseNum *= -1;
                    return reverseNum;
                }
                return reverseNum;
            }
            catch {
                return 0;
            }
         }
    }
}