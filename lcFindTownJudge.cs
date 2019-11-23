using System;
using System.Collections.Generic;

namespace CSharp_Practice
{

    // INCOMPLETE SOLUTION
    public class lcFindTownJudge
    {
        public int FindJudge(int N, int[][] trust) 
        {
            var d = new Dictionary<int, int>();
            foreach (var pair in trust)
            {
                d.Add(pair[0], pair[1]);
            }
            for (int i = 0; i < N; i++)
            {
                if (!d.ContainsKey(i))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}