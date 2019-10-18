namespace CSharp_Practice
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S) {
        int i = 0;
        int res = 0;
        for(i = 0; i < S.Length; i++)
        {
            if (J.Contains(S[i]))
                res++;
        }
        return res;
    }
    }
}