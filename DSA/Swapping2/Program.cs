using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swapping2
{
    class Program
    {
        private static Queue<int> numbers;

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            numbers = new Queue<int>(count);
            for (int i = 1; i <= count; i++)
            {
                numbers.Enqueue(i);
            }

            Calculate();
        }

        public static async Task Calculate()
        {
            var task = SwapAsync(numbers, new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray()));
            var result = await task;
            Console.WriteLine(string.Join(" ", numbers.ToArray()));
        }

        public async static Task<Queue<int>> SwapAsync(Queue<int> numbers, Queue<int> values)
        {
            if (values.Count == 0)
            {
                return numbers;
            }
            int current = values.Dequeue();
            numbers.Enqueue(current);
            while (numbers.Peek() != current)
            {
                numbers.Enqueue(numbers.Dequeue());
            }
            numbers.Dequeue();
            return await SwapAsync(numbers, values);
        }
    }
}