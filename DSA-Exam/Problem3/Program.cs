using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var slide = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "add":
                        slide.Enqueue(int.Parse(command[1]));
                        Console.WriteLine("Added " + command[1]);
                        break;
                    case "slide":
                        var times = int.Parse(command[1]);
                        for (int k = 0; k < times; k++)
                        {
                            slide.Enqueue(slide.Dequeue());
                        }
                        Console.WriteLine("Slided " + times);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", slide.Reverse()));
                        break;
                }
            }
        }
    }
}
