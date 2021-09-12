
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public class Graph{
            private List<int>[] _adj;
            private int _v;
            public Graph(int v){
                _v = v;
                _adj = new List<int>[v];
                for(int i=0;i<v;i++) 
                    _adj[i] = new List<int>();
            }
            public void AddEdge(int v,int e){
                _adj[v].Add(e);
            }
            public void dfs(int startV){
                bool[] visited = new bool[_v];
                dfsUtil(startV,visited);
            }
            public void dfsUtil(int v,bool[] visited){
                visited[v] = true;
                Console.WriteLine(v);
                foreach(var item in _adj[v]){
                    if(!visited[item])
                        dfsUtil(item,visited);
                }
            }
        }
        public static void Main(string[] args)
        {
            Graph g = new Graph(4);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            g.dfs(2);
        }
    }
}