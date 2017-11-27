using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public static class SortingAlgorithms
    {
        public static IEnumerable<int> CountingSort(IList<int> toSort, int min, int max)
        {
            int[] holder = new int[max - min + 1];
            for (int i = 0; i < toSort.Count; i++)
            {
                holder[toSort[i] - min]++;
            }

            List<int> res = new List<int>(toSort.Count);
            for (int i = 0; i < holder.Length; i++)
            {
                while (holder[i] > 0)
                {
                    res.Add(i + min);
                    holder[i]--;
                }
            }
            return res;
        }

        public static IEnumerable<T> CountingSort<T>(IEnumerable<T> input, int min, int max, Func<T, int> getValue)
        {
            var holder = new Stack<T>[max - min + 1];

            foreach (T item in input)
            {
                int pos = getValue(item) - min;
                if (holder[pos] == null)
                {
                    holder[pos] = new Stack<T>();
                }
                holder[pos].Push(item);
            }
            return holder.Where(c => c != null).SelectMany(x => x).ToArray();
        }

        public static IEnumerable<T> CountingHashSort<T>(IEnumerable<T> input, int min, Func<T, int> getValue)
        {
            var map = new HashSet<T>();

            var counts = new List<int>();

            int inputCount = 0;
            foreach (var item in input)
            {
                inputCount++;
                if (map.Add(item))
                {
                    counts.Add(1);

                }
                else
                {
                    counts[getValue(item) - min]++;
                }
            }

            T[] res = new T[inputCount];
            T[] items = map.ToArray();
            for (int i = 0; i < counts.Count; i++)
            {
                T item = items[i];
                for (int j = 0; j < i; j++)
                {
                    res[j] = item;
                }
            }
            return res;
        }

        public static void SelectionSort(this int[] n)
        {
            for (int j = 0; j < n.Length - 1; j++)
            {
                int min = j;
                for (int i = j + 1; i < n.Length; i++)
                {
                    if (n[min] > n[i])
                    {
                        min = i;
                    }
                }

                if (min != j)
                {
                    n.Swap(j, min);
                }
            }
        }

        public static void BubbleSort(this IList<int> n)
        {
            bool IsSorted = false;
            while (!IsSorted)
            {
                IsSorted = true;
                for (int i = 0; i < n.Count - 1; i++)
                {
                    if (n[i] > n[i + 1])
                    {
                        n.Swap(i, i + 1);
                        IsSorted = false;
                    }
                }

            }
        }

        //do 20 elementa e nai-burz
        public static void InsertionSort(this IList<int> n)
        {
            for (int i = 1; i < n.Count; i++)
            {
                int pos = i;

                while (pos > 0 && n[pos] < n[pos - 1])
                {
                    n.Swap(pos, pos - 1);
                    pos--;
                }
            }
        }

        public static IEnumerable<int> QuickSort(this IList<int> n)
        {
            if (n.Count < 2)
            {
                return n;
            }

            int pivodIndex = n.Count / 2;
            List<int> left = new List<int>(pivodIndex);
            List<int> right = new List<int>(pivodIndex);

            for (int i = 0; i < n.Count; i++)
            {
                if (i == pivodIndex)
                {
                    continue;
                }

                if (n[i] < n[pivodIndex])
                {
                    left.Add(n[i]);
                }
                else
                {
                    right.Add(n[i]);
                }
            }
            List<int> result = new List<int>(n.Count);

            result.AddRange(QuickSort(left));
            result.Add(n[pivodIndex]);
            result.AddRange(QuickSort(right));
            return result;
        }

        private static void Swap<T>(this IList<T> source, int oldIndex, int newIndex)
        {
            T temp = source[oldIndex];
            source[oldIndex] = source[newIndex];
            source[newIndex] = temp;
        }
    }
}
