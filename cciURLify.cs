using System.Text;

namespace Practice
{
    public class URLify
    {
        static string ReplaceWhiteSpace(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var letter in s)
            {
                if (letter == ' ')
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(letter);
                }
            }
            string str = sb.ToString();
            return str;
        }
    }
}