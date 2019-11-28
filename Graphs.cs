using System.Collections.Generic;
using System;
using System.Text;

namespace CSharp_Practice
{
    public class Graphs
    {
        //Graph = (Vertices, Edges)
        IList<Vertex> listOfVertices { get; set; }  
        IList<IList<Vertex>> adjacencyList { get; set; }  

        public void PrintTopologicalSorting()
        {
            Stack<string> s = new Stack<string>();

            while (listOfVertices.Count > 0)
            {
                int i;
                for (i = 0; i < listOfVertices.Count; i++)
                {
                    if (adjacencyList[i].Count == 0)
                    {
                        break;
                    }
                }
                if (i != adjacencyList.Count)
                {
                    s.Push(listOfVertices[i].Label);
                    RemoveVertex(listOfVertices[i].Label);
                }
            }
        }
        public string PrintAdjacencyList()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listOfVertices.Count; i++)
            {
                foreach (var v in adjacencyList[i])
                {
                    sb.Append(v);
                }
            }
            return sb.ToString();
        }
        //add vertex
        public void AddVertex(string name)
        {
            Vertex v1 = new Vertex(name);
            listOfVertices.Add(v1);
            adjacencyList.Add(new List<Vertex>{v1});
        }

        public void RemoveVertex(string name)
        {
            int i = 0;
            while(i < listOfVertices.Count)
            {
                if (listOfVertices[i].Label == name)
                {
                    listOfVertices.RemoveAt(i);
                    break;
                }
            }

            adjacencyList.RemoveAt(i);
            foreach (var list in adjacencyList)
            {
                for (int j = list.Count - 1; j >= 0 ; j--)
                {
                    if (list[j].Label == name)
                    {
                        list.RemoveAt(j);
                    }
                }
            }
        }

        public void AddEdge(string start, string end, int weight = 1)
        {
            int i = -1;
            for (i = 0; i < listOfVertices.Count; i++)
            {
                if (listOfVertices[i].Label == start)
                {
                    break;
                }
            }

            if (i == listOfVertices.Count)
            {
                throw new Exception($"{start} was not found");
            }

            adjacencyList[i].Add(new Vertex(end));
        }

        public void RemoveEdge(string start, string end)
        {
            int i = -1;
            for (i = 0; i < listOfVertices.Count; i++)
            {
                if (listOfVertices[i].Label == start)
                {
                    break;
                }
            }

            if (i == listOfVertices.Count)
            {
                throw new Exception($"{start} was not found");
            }

            for (int j = 0; j < adjacencyList[i].Count; j++)
            {
                if (adjacencyList[i][j].Label == end)
                {
                    adjacencyList[i].RemoveAt(j);
                    break;
                }
            }
            adjacencyList[i].Add(new Vertex(end));
        }

        //add vertices
        //display edges and vertices
        public Graphs()
        {
            listOfVertices = new List<Vertex>();
            adjacencyList = new List<IList<Vertex>>();
        }

    }

    public class Vertex
    {
        public bool IsVisited { get; set; }     
        public string Label { get; set; }
        public (int, int) Pair { get; set; }
        public Vertex(string name)
        {
            Label = name;
        }
    }
}