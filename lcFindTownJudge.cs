using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Practice
{

    // INCOMPLETE SOLUTION
    public class lcFindTownJudge
    {
        public int FindJudge(int N, int[][] trust) 
        {
            var d = new Dictionary<int, List<int>>();
            foreach (var rel in trust)
            {
                if (d.ContainsKey(rel[0]))
                    d[rel[0]].Add(rel[1]);
                else
                    d.Add(rel[0], new List<int>{rel[1]});
            }
            if (d.Keys.Count == N)
                return -1;
            var keyHash = d.Keys.ToHashSet();
            var valHash = new HashSet<int>();
            foreach (var rel in d.Values)
            {
                foreach (var item in rel)
                {
                    valHash.Add(item);
                }
            }
            var possJudges = new List<int>();
            foreach (var item in valHash)
            {
                if (keyHash.Add(item) == true)
                {
                    possJudges.Add(item);
                }
            }
            if(possJudges.Count == 0)
                return -1;
                for (int i = 0; i < possJudges.Count; i++)
                {
                    foreach (var item in d.Values)
                    {
                        if (item.Contains(possJudges[i]))
                        {
                            possJudges.RemoveAt(i);
                        }
                    }
                }
            
            if (possJudges.Count == 1)
                return possJudges[0];
            else
            {
                return -1;
            }
        }
    }
}