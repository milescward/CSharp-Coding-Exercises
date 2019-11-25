using System.Collections.Generic;

namespace CSharp_Practice
{
    //INCOMPLETE
    public class lcCriticalConnections
    {
        public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections) 
        {
            var d = new Dictionary<int, List<int>>();
            foreach (var c in connections)
            {
                if (d.ContainsKey(c[0]))
                    d[c[0]].Add(c[1]);
                else
                    d.Add(c[0], new List<int>{c[1]});
                if (d.ContainsKey(c[1]))
                    d[c[1]].Add(c[0]);
                else
                    d.Add(c[1], new List<int>{c[0]});
            }
            var q = new Queue<int>();
            var results = new List<IList<int>>();
            for(int i = 0; i < n; i++)
            {
                if (d[i].Count == 1)
                    results.Add( new List<int>{i, d[i][0]});
                    q.Enqueue(i);
            }
            if (results.Count == n)
                return connections;
            while (q.Count != 0)
            {
                int num = q.Dequeue();
                foreach (var key in d.Keys)
                {
                    if (d[key].Contains(num))
                        d[key].Remove(num);
                    if (d[key].Count == 1)
                    {
                        results.Add(new List<int>{key, d[key][0]});
                        q.Enqueue(d[key][0]);
                    }
                }
            }
            return results;
        }
    }
}