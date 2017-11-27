using System;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        private static int start = 0;
        static void Main()
        {
            //get start
            start = int.Parse(Console.ReadLine());
            //Get Map
            int[] map = GetMap(Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
            //Start moving
            int sumFor = 0, sumBack = 0;
            string instruction = Console.ReadLine();
            while (instruction != "exit")
            {
                string[] instructionData = instruction.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int times = int.Parse(instructionData[0]);
                int step = int.Parse(instructionData[2]);
                if (instructionData[1].Contains("for"))
                {
                    sumFor += GetCountForward(map, times, step);
                }
                else
                {
                    sumBack += GetCountBackward(map, times, step);
                }

                instruction = Console.ReadLine();
            }
            Console.WriteLine("Forward: " + sumFor);
            Console.WriteLine("Backwards: " + sumBack);
        }

        private static int[] GetMap(string[] input)
        {
            List<int> list = new List<int>();
            foreach (var item in input)
            {
                list.Add(int.Parse(item));
            }
            return list.ToArray();
        }

        private static int GetCountBackward(int[] numbers, int times, int step)
        {
            int sum = 0;
            while (times != 0)
            {
                start -= step;

                while (start < 0)
                {
                    start = start + numbers.Length;
                }
                sum += numbers[start];
                times--;
            }
            return sum;
        }

        private static int GetCountForward(int[] numbers, int times, int step)
        {
            int sum = 0;
            while (times != 0)
            {
                start += step;
                while (start >= numbers.Length)
                {
                    start = start - numbers.Length;
                }
                sum += numbers[start];
                times--;
            }
            return sum;
        }
    }
}
