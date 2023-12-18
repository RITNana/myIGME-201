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

        // adjacency matrix for our colors
        static int[,] mGraph = new int[,]
              {
             /*red*/   /*indigo*/ /*gray*/  /*blue*/ /*orange*/ /*violet*/ /*yellow*/ /*green*/
  /*Red*/    { -1   ,    1    ,      5   ,     -1   ,    -1    ,    -1   ,      -1   ,  -1 },
  /*Indigo*/ { -1   ,   -1   ,      -1   ,      1    ,   -1   ,     -1   ,       8   ,  -1 },
  /*Gray*/   { -1    ,  -1   ,      -1   ,     -1   ,     1   ,     -1   ,      -1   ,  -1 },
  /*Blue*/   { -1   ,    1   ,      -1   ,     -1   ,    -1   ,     -1   ,      -1   ,  -1 },
  /*Orange*/ { -1   ,   -1   ,      -1   ,     -1   ,    -1   ,      1   ,      -1    , -1 },
  /*Violet*/ { -1   ,   -1   ,      -1   ,     -1   ,    -1   ,     -1   ,       1   ,  -1 },
  /*Yellow*/ { -1   ,   -1   ,      -1   ,     -1   ,    -1   ,     -1   ,      -1  ,    6 },
  /*Green*/  { -1   ,   -1   ,      -1   ,     -1   ,    -1   ,     -1,         -1   ,  -1 }
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

        // adjacency weighted list
        static int[][] wGraph = new int[][]
       {
        /* Red */    new int[] {1 ,5},
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

        // Create our color nodes
        // Assign the edge values to the,
        // Use Depth First Search
        // Use Dijkstra's Shortest Path
        static void Main(string[] args)
        {

            PrintAdjacencyMatrix(mGraph); // displasy the Adjacecncy Matrix
            Console.WriteLine();
            PrintAdjacencyList(lGraph); // Displays the Adjacency List
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

            

            // Get the shortest path after starting the DFS thread
            List<Node> shortestPath = GetShortestPathDijkstra();

            // Output the nodes in the shortest path
            Console.WriteLine("Shortest Path from Red to Green:");
            foreach (var color in shortestPath)
            {
                Console.WriteLine(((EColorState)color.nState).ToString());
            }





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


        // Print out the Adjancency Matrix 
        static void PrintAdjacencyMatrix(int[,] matrix)
        {
            Console.WriteLine("Adjacency Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] != -1 ? matrix[i, j] + " " : "- ");
                }
                Console.WriteLine();
            }
        }

        // Print out the Adjancency List 
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

        static public List<Node> GetShortestPathDijkstra()
        {
            // set up all distances from every vertex to the start vertex
            DijkstraSearch();

            // the list of nodes that will be the shortest path from the start
            List<Node> shortestPath = new List<Node>();

            // add the target node
            shortestPath.Add(colors[(int)EColorState.green]);

            // populate the List of nodes from the target node back to the start
            BuildShortestPath(shortestPath, colors[(int)EColorState.green]);

            // reverse the List to give the path from the start to the finish
            shortestPath.Reverse();

            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }

        static private int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            Node start = colors[(int)EColorState.red];

            start.minCostToStart = 0;
            List<Node> prioQueue = new List<Node>();
            prioQueue.Add(start);

            //Func<Node, int> nodeOrderBy = new Func<Node, int>(NodeOrderBy);
            Func<Node, int> nodeOrderBy = NodeOrderBy;

            do
            {
                // sort our prioQueue by minCostToStart
                // option #1, use .Sort() which sorts in place
                prioQueue.Sort();

                Node node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (Edge cnn in node.edges)
                // if we do not sort each list of edges after populating them for a node,
                // we can create a temporary sorted list for this loop
                //.OrderBy(delegate(Edge n) { return n.cost; }))
                {
                    // look at the neighbor connected to this edge
                    Node neighborNode = cnn.connectedNode;
                    if (neighborNode.visited)
                    {
                        // skip if we already visited this neighbor
                        continue;
                    }

                    // if this neighbor has not been evaluated yet or
                    // it is closer than the current path to start
                    if (neighborNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < neighborNode.minCostToStart)
                    {
                        // update the cost to start
                        neighborNode.minCostToStart = node.minCostToStart + cnn.cost;

                        // set the node heading back to start from this neighbor to the 
                        // node we got here by
                        neighborNode.nearestToStart = node;

                        // if we don't have this neighbor in our queue
                        if (!prioQueue.Contains(neighborNode))
                        {
                            // add it
                            prioQueue.Add(neighborNode);
                        }
                    }
                }

                // set this node as visited
                node.visited = true;

                // if we reached the target node
                if (node == colors[(int)EColorState.green])
                {
                    // we're done!
                    return;
                }

                // stay in this loop while there are any items left in our queue
            } while (prioQueue.Any());
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


