using System;
using System.Text;

namespace CSharp_Practice
{
    public class lcStringToIntegerAtoi
    {
        public int myAtoi(string str)
        {
            // Check for null or empty
            if(string.IsNullOrWhiteSpace(str) || str == null)
                return 0;
            bool isNegative = false;
            int lp = 0;
            int rp = 0;
            string newStr = str.Trim();
            // discard whitespaces unitl num is reached
            if(char.IsLetter(newStr[lp]))
                return 0;
            // optional + or -
            if (lp == '-')
            {
                isNegative = true;
                lp++;
            }
            else if (lp == '+')
            {
                lp++;
            }
            // string of digits
            rp = lp;
            StringBuilder sb = new StringBuilder();
            while (char.IsDigit(newStr[rp]) && (rp < newStr.Length))
            {
                sb.Append(newStr[rp]);
                rp++;
            }
            string retStr = sb.ToString();
            return Convert.ToInt32(retStr);
        }
    }
}