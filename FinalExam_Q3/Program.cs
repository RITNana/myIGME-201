// define as a digraph
// define as a adjacency matrix AND list


#define DIGRAPH
#define USE_MATRIX
# define USE_LIST

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalExam_ColorDigraph
{
    enum EColorState
    {
        red,
        indigo,
        gray,
        blue,
        orange,
        violet,
        yellow,
        green
    }
    static class Program
    {
#if DIGRAPH

#if USE_MATRIX
        // the adjacency values for the directed graph version.  
        // Only allow the paths that reach the goal

        // adjacency matrix
        static bool[,] mGraph = new bool[,]
              {
             /*red*/   /*indigo*/ /*gray*/  /*blue*/ /*orange*/ /*violet*/ /*yellow*/ /*green*/
  /*Red*/    { false   , true    , true   , false   , false    , false   , false   , false },
  /*Indigo*/ { false   , false   , false   , true    , false   , false   , true   , false },
  /*Gray*/   { false    , false   , false   , true   , true   , false   , false   , false },
  /*Blue*/   { false   , true   , true   , false   , false   , false   , false   , false },
  /*Orange*/ { false   , false   , false   , false   , false   , true   , false    , false },
  /*Violet*/ { false   , false   , false   , false   , false   , false   , true   , false },
  /*Yellow*/ { false   , false   , false   , false   , false   , false   , false   , true },
  /*Green*/  { false   , false   , false   , false   , false   , false    , false   , false }
              };
#endif


#if USE_LIST
        // adjacency list
        static int[][] lGraph = new int[][]
        {
        /* Red */    new int[] { (int)EColorState.indigo,(int)EColorState.gray },
        /* Indigo */    new int[] { (int)EColorState.blue, (int)EColorState.yellow },
        /* Gray */    new int[] { (int)EColorState.orange },
        /* Blue */    new int[] { (int)EColorState.indigo },
        /* Orange */    new int[] {(int)EColorState.violet },
        /* Violet */    new int[]{(int)EColorState.yellow },
        /* Yellow */    new int[] {(int)EColorState.green },
        /* Green */    null
        };

        static int[][] wGraph = new int[][]
       {
        /* Red */    new int[] {1 ,5 },
        /* Indigo */    new int[] {1, 8},
        /* Gray */    new int[] {1},
        /* Blue */    new int[] {1 },
        /* Orange */    new int[] {1},
        /* Violet */    new int[]{1 },
        /* Yellow */    new int[] {6},
        /* Green */    null
       };
#endif


#endif


        static List<Node> colors;

        static int nState = 0;

        static void Main(string[] args)
        {

          PrintAdjacencyMatrix(mGraph);
            Console.WriteLine();
            PrintAdjacencyList(lGraph);
            Console.WriteLine(); 

            colors = new List<Node>();
            Node node;

            node = new Node((int)EColorState.red);
            colors.Add(node);

            node = new Node((int)EColorState.indigo);
            colors.Add(node);

            node = new Node((int)EColorState.gray);
            colors.Add(node);

            node = new Node((int)EColorState.blue);
            colors.Add(node);

            node = new Node((int)EColorState.orange);
            colors.Add(node);

            node = new Node((int)EColorState.violet);
            colors.Add(node);

            node = new Node((int)EColorState.yellow);
            colors.Add(node);

            node = new Node((int)EColorState.green);
            colors.Add(node);

            // Red and its edges 
            colors[(int)EColorState.red].AddEdge(1, colors[(int)EColorState.indigo]);
            colors[(int)EColorState.red].AddEdge(5, colors[(int)EColorState.gray]);
            colors[(int)EColorState.red].edges.Sort();

            //Indigo and its edges
            colors[(int)EColorState.indigo].AddEdge(1, colors[(int)EColorState.blue]);
            colors[(int)EColorState.indigo].AddEdge(8, colors[(int)EColorState.yellow]);
            colors[(int)EColorState.indigo].edges.Sort();

            //Gray and its edges
            colors[(int)EColorState.gray].AddEdge(-1, colors[(int)EColorState.blue]);
            colors[(int)EColorState.gray].AddEdge(1, colors[(int)EColorState.orange]);
            colors[(int)EColorState.gray].edges.Sort();

            //Blue and its edges
            colors[(int)EColorState.blue].AddEdge(-1, colors[(int)EColorState.gray]);
            colors[(int)EColorState.blue].AddEdge(1, colors[(int)EColorState.indigo]);
            colors[(int)EColorState.blue].edges.Sort();


            //Orange and its edges
            colors[(int)EColorState.orange].AddEdge(1, colors[(int)EColorState.violet]);
            colors[(int)EColorState.orange].edges.Sort();

            // Violet and its edges
            colors[(int)EColorState.yellow].AddEdge(1, colors[(int)EColorState.yellow]);
            colors[(int)EColorState.yellow].edges.Sort();

            // Yellow and its edges
            colors[(int)EColorState.yellow].AddEdge(6, colors[(int)EColorState.green]);
            colors[(int)EColorState.yellow].edges.Sort();


            // create a thread for the Depth First Search and start search
              Thread t = new Thread(DFS);
              t.Start();

          


        }

        static void DFSUtil(int v, bool[] visited)
        {
            // Mark the current node as visited 
            visited[v] = true;

            // Get the color name and print it
            string colorName = ((EColorState)v).ToString();
            Console.WriteLine(colorName);

            // Recur for all the vertices adjacent to this vertex if there are any
            int[] thisStateList = lGraph[v];
            if (thisStateList != null)
            {
                foreach (int n in thisStateList)
                {
                    if (!visited[n])
                    {
                        DFSUtil(n, visited);
                    }
                }
            }
        }

        // The function to do DFS traversal. 
        // It uses recursive DFSUtil() 
        static void DFS()
        {
            // Mark all the vertices as not visited 
            // (set as false by default in C#) 
            bool[] visited = new bool[lGraph.Length];

            // Call the recursive helper function 
            // to print DFS traversal 
            // Start from the red node (assuming red is at index 0)
            Console.WriteLine("DFS Traversal Completed. Colors visited:");
            DFSUtil(0, visited);
        }

          static void PrintAdjacencyMatrix(bool[,] matrix)
          {
              Console.WriteLine("Adjacency Matrix:");
              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                  for (int j = 0; j < matrix.GetLength(1); j++)
                  {
                      Console.Write(matrix[i, j] ? "1 " : "0 ");
                  }
                  Console.WriteLine();
              }
          }

          static void PrintAdjacencyList(int[][] list)
          {
              Console.WriteLine("Adjacency List:");
              for (int i = 0; i < list.Length; i++)
              {
                  Console.Write($"Node {i}: ");
                  if (list[i] != null)
                  {
                      foreach (var edge in list[i])
                      {
                          Console.Write($"{edge} ");
                      }
                  }
                  Console.WriteLine();
              }
          } 

        public class Node : IComparable<Node>
        {
            public int nState;
            public List<Edge> edges = new List<Edge>();

            public int minCostToStart;
            public Node nearestToStart;
            public bool visited;

            public Node(int nState)
            {
                this.nState = nState;
                this.minCostToStart = int.MaxValue;
            }

            public void AddEdge(int cost, Node connection)
            {
                Edge e = new Edge(cost, connection);
                edges.Add(e);
            }

            public int CompareTo(Node n)
            {
                return this.minCostToStart.CompareTo(n.minCostToStart);
            }
        }

        public class Edge : IComparable<Edge>
        {
            public int cost;
            public Node connectedNode;

            public Edge(int cost, Node connectedNode)
            {
                this.cost = cost;
                this.connectedNode = connectedNode;
            }

            public int CompareTo(Edge e)
            {
                return this.cost.CompareTo(e.cost);
            }
        }
    }
}

