using System.Collections.Generic;

namespace Graphs
{
    public class Node
    {

    }

    public class Connectivity
    {
        HashSet<Node> visited = new HashSet<Node>();
        Dictionary<Node, HashSet<Node>> graph = new Dictionary<Node, HashSet<Node>>();

        public int ConnectedGraphs(ICollection<Node> visited, Dictionary<Node, HashSet<Node>> graph)
        {
            int connectedGraphs = 0;
            foreach (var key in graph.Keys)
            {
                foreach (var node in graph[key])
                {
                    if (!visited.Contains(node))
                    {
                        BFS(node);
                        connectedGraphs++;
                    }
                }
            }

            return connectedGraphs;
        }

        public void DFS(Node node)
        {
            var stack = new Stack<Node>();
            stack.Push(node);
            this.visited.Add(node);

            while (stack.Count != 0)
            {
                var currentNode = stack.Pop();
                var connections = this.graph[currentNode];
                foreach (var child in connections)
                {
                    if (!this.visited.Contains(child))
                    {
                        stack.Push(child);
                        this.visited.Add(child);
                    }
                }
            }
        }

        public void BFS(Node node)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(node);
            this.visited.Add(node);

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();
                var connections = this.graph[currentNode];
                foreach (var child in connections)
                {
                    if (!this.visited.Contains(child))
                    {
                        queue.Enqueue(child);
                        this.visited.Add(child);
                    }
                }
            }
        }
        
    }
}