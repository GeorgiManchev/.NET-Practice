using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineMarket
{
    class Program
    {
        static void Main()
        {

            var names = new SortedSet<Product>();
            var kinds = new Dictionary<string, SortedSet<Product>>(32768);

            var args = Console.ReadLine().Split();
            while (args[0] != "end")
            {
                if (args[0] == "add")
                {
                    var item = new Product { Name = args[1], Price = double.Parse(args[2]), Kind = args[3] };
                    if (names.Add(item))
                    {
                        if (!kinds.ContainsKey(item.Kind))
                        {
                            kinds.Add(item.Kind, new SortedSet<Product>());
                        }
                        kinds[item.Kind].Add(item);
                        Console.Write("Ok: Product {0} added successfully", item.Name);
                    }
                    else
                    {
                        Console.Write("Error: Product {0} already exists", item.Name);
                    }
                }
                else if (args[2] == "type")
                {
                    var kind = args[3];
                    if (kinds.ContainsKey(kind))
                    {
                        PrintListToConsole(kinds[kind].Take(10));
                    }
                    else
                    {
                        Console.Write("Error: Type {0} does not exists", kind);
                    }
                }
                else
                {
                    Console.Write("Ok: ");
                    var price = double.Parse(args[4]);
                    if (args.Length == 7)
                    {//min and max
                        var max = double.Parse(args[6]);
                        if (names.Min.Price <= price && names.Max.Price >= max)
                        {
                            PrintListToConsole(names.Where(x => x.Price >= price && x.Price <= max).Take(10));
                        }
                    }
                    else if (args[3] == "from")
                    {
                        //min price
                        if (names.Max.Price >= price)
                        {
                            var lower = names.First(x => x.Price > price);
                            PrintListToConsole(names.GetViewBetween(lower, names.Max).Take(10));
                        }
                    }
                    else
                    {
                        //min price
                        if (names.Min.Price <= price)
                        {
                            var lower = names.Last(x => x.Price <= price);
                            PrintListToConsole(names.GetViewBetween(names.Min, lower).Reverse().Take(10).Reverse());
                        }
                    }
                }
                Console.WriteLine(); //just end line
                args = Console.ReadLine().Split();
            }
        }

        public static void PrintListToConsole(IEnumerable<Product> collection)
        {
            Console.Write(string.Join(", ", collection));
        }
    }
}
