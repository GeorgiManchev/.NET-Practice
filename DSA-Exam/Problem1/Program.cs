using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    public class Program
    {
        static void Main()
        {
            var clients = new Dictionary<int, HashSet<Order>>(32768);
            var orders = new List<Order>(65536);

            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                var input = Console.ReadLine();
                var commandType = input.Split()[0];
                var command = input.Substring(commandType.Length + 1).Split(';');
                switch (commandType)
                {
                    case "AddOrder":
                        var name = command[0];
                        var price = double.Parse(command[1]);
                        var client = command[2];
                        var order = new Order { Name = name, Price = price, Client = client };
                        var key = client.GetHashCode();
                        if (!clients.ContainsKey(key))
                        {
                            clients.Add(key, new HashSet<Order>());
                        }
                        clients[key].Add(order);
                        orders.Add(order);
                        Console.WriteLine("Order added");
                        break;
                    case "DeleteOrders":
                        client = command[0];
                        key = client.GetHashCode();
                        if (clients.ContainsKey(key))
                        {
                            var allOrdersFromClient = clients[key];
                            clients.Remove(key);
                            orders.RemoveAll(x => x.Client == client);
                            Console.WriteLine("{0} orders deleted", allOrdersFromClient.Count);
                        }
                        else
                        {
                            Console.WriteLine("No orders found");
                        }

                        break;
                    case "FindOrdersByConsumer":
                        key = command[0].GetHashCode();
                        if (clients.ContainsKey(key))
                        {
                            foreach (var item in clients[key].OrderBy(x => x.Price))
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No orders found");
                        }
                        break;
                    case "FindOrdersByPriceRange":
                        var start = double.Parse(command[0]);
                        var end = double.Parse(command[1]);

                        var ordersByRange = orders.Where(x => (x.Price >= start && x.Price <= end)).OrderBy(x => x.Name);
                        int count = 0;
                        foreach (var item in ordersByRange)
                        {
                            Console.WriteLine(item);
                            count++;
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("No orders found");
                        }
                        break;
                }
            }
        }
    }

    public struct Order : IComparable<Order>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Client { get; set; }

        public override string ToString()
        {
            string price = string.Format("{0:F2}", Price);
            return "{" + Name + ";" + Client + ";" + price + "}";
        }

        public int CompareTo(Order other)
        {
            int res = this.Price.CompareTo(other.Price);
            if (res == 0)
            {
                res = this.Name.CompareTo(other.Name);
            }
            return res;
        }
    }
}