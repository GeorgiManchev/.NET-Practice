using System;
using System.Collections.Generic;

namespace Problem4
{
    public struct Food
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Protein { get; set; }

    }

    public class Program
    {
        static void Main()
        {
            var maxGrams = int.Parse(Console.ReadLine());
            var foodCount = byte.Parse(Console.ReadLine());

            var foods = new List<Food>(32);
            var dp = new int[foodCount + 1, maxGrams + 1];
            var backTrack = new int[foodCount + 1, maxGrams + 1];
            for (int i = 1; i <= foodCount; i++)
            {
                var input = Console.ReadLine().Split();
                foods.Add(new Food { Name = input[0], Weight = int.Parse(input[1]), Protein = int.Parse(input[2]) });

                var current = foods[i - 1];
                for (int j = 1; j <= maxGrams; j++)
                {
                    var notUsedValue = dp[i - 1, j];
                    var usedValue = 0;
                    if (j - current.Weight >= 0)
                    {
                        usedValue = dp[i - 1, j - current.Weight] + current.Protein;
                    }

                    if (usedValue >= notUsedValue && usedValue != 0)
                    {
                        dp[i, j] = usedValue;
                        backTrack[i, j] = j - current.Weight;
                    }
                    else
                    {
                        dp[i, j] = notUsedValue;
                    }
                }
            }

            //find Max
            int max = 0;
            int index = 0;
            for (int i = 0; i < maxGrams + 1; i++)
            {
                if (dp[foods.Count, i] > max)
                {
                    max = dp[foodCount, i];
                    index = i;
                }
            }

            Console.WriteLine(max);

            for (int i = foodCount; i > 0; i--)
            {
                if (dp[i, index] != dp[i - 1, index])
                {
                    Console.WriteLine(foods[i - 1].Name);
                    index = backTrack[i, index];
                }
            }
        }
    }
}
