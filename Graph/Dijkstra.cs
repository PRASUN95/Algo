//Initial Template for C#
//Shortest path to all nodes from source using Set

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                var ip = Console.ReadLine().Trim().Split(' ');
                int V = int.Parse(ip[0]);
                int E = int.Parse(ip[1]);
                List<List<List<int>>> adj = new List<List<List<int>>>();
                for (int i = 0; i < V; i++)
                {
                    adj.Add(new List<List<int>>());
                }
                for (int i = 0; i < E; i++)
                {
                    ip = Console.ReadLine().Trim().Split(' ');
                    int u = int.Parse(ip[0]);
                    int v = int.Parse(ip[1]);
                    int w = int.Parse(ip[2]);

                    adj[u].Add(new List<int>() { v, w });
                    adj[v].Add(new List<int>() { u, w });
                }
                int S = Convert.ToInt32(Console.ReadLine());
                Solution obj = new Solution();
                var res = obj.dijkstra(V, ref adj, S);
                foreach (int i in res)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

// } Driver Code Ends


//User function Template for C#

class Solution
{
    //Function to find the shortest distance of all the vertices
    //from the source vertex S.
    public List<int> dijkstra(int V, ref List<List<List<int>>> adj, int S)
    {
        //code here
        	var dist = new List<int>();
			for (int i = 0; i < V; i++)
			{
				dist.Add(int.MaxValue);
			}
			dist[S] = 0;
			var set = new SortedSet<(int cost, int node)>();
			set.Add((0, S));
			while (set.Count > 0)
			{
				int node = set.Min.node;
				int cost = set.Min.cost;
				set.Remove((cost, node));
				foreach (var edge in adj[node])
				{
					int i = edge[0];
					if (edge[1] + cost < dist[i])
					{
						if(set.Contains((dist[i], i)))
						 set.Remove((dist[i], i));
						dist[i] = edge[1] + cost;
						set.Add((dist[i], i));
					}
				}
			}
			//Console.Write(string.Join(" ", dist));
			return dist;
    }
}

