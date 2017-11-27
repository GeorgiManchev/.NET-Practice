using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    public class Node : IComparable<Node>
    {
        private readonly SortedSet<Node> parents;
        private readonly int value;

        public Node(int value)
        {
            this.parents = new SortedSet<Node>();
            this.value = value;
        }

        public SortedSet<Node> Parents { get { return this.parents; } }
        public int Value { get { return this.value; } }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public int CompareTo(Node other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var nodes = new SortedDictionary<int, Node>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var comParams = Console.ReadLine().Replace("is ", null).Split();
                string condition = comParams[1];

                var childValue = int.Parse(comParams[0]);
                var parentValue = int.Parse(comParams[2]);

                if (condition == "before")
                {
                    childValue = int.Parse(comParams[2]);
                    parentValue = int.Parse(comParams[0]);
                }

                if (!nodes.ContainsKey(childValue))
                {
                    nodes.Add(childValue, new Node(childValue));
                }

                var parentNode = new Node(parentValue);
                nodes[childValue].Parents.Add(parentNode);

                if (!nodes.ContainsKey(parentValue))
                {
                    nodes.Add(parentValue, parentNode);
                }
            }

            var result = new HashSet<int>();
            bool isFirstIteration = true;
            while (nodes.Count > 0)
            {
                var first = nodes.Values.First(x => x.Parents.Count == 0);
                if (isFirstIteration && first.Value == 0)
                {
                    first = nodes.Values.Skip(1).First(x => x.Parents.Count == 0);
                }
                result.Add(first.Value);
                nodes.Remove(first.Value);
                foreach (var item in nodes.Values)
                {
                    item.Parents.Remove(first);
                }
                isFirstIteration = false;
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
