using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitsOfWork
{
    public class Unit : IComparable<Unit>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Attack { get; set; }

        public override string ToString()
        {
            return string.Format("{0}[{1}]({2})", Name, Type, Attack);
        }

        public int CompareTo(Unit other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result != 0)
            {
                result = other.Attack.CompareTo(this.Attack);
                if (result == 0)
                {
                    result = this.Name.CompareTo(other.Name);
                }
            }
            return result;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var units = new SortedSet<Unit>();
            var unitNames = new Dictionary<string, Unit>(50000);
            var unitTypes = new Dictionary<string, SortedSet<Unit>>(128);

            string[] command;
            while ((command = Console.ReadLine().Split())[0] != "end")
            {
                switch (command[0])
                {
                    case "add":
                        var name = command[1];
                        var type = command[2];
                        var attack = int.Parse(command[3]);
                        var unit = new Unit { Name = name, Type = type, Attack = attack };
                        if (units.Add(unit))
                        {
                            unitNames.Add(unit.Name, unit);
                            if (!unitTypes.ContainsKey(type))
                            {
                                unitTypes.Add(type, new SortedSet<Unit>());
                            }
                            unitTypes[type].Add(unit);
                            Console.WriteLine(string.Format("SUCCESS: {0} added!", unit.Name));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Format("FAIL: {0} already exists!", unit.Name));
                        }
                        break;
                    case "remove":
                        name = command[1];
                        if (unitNames.ContainsKey(name))
                        {
                            var holder = unitNames[name];
                            units.Remove(holder);
                            unitTypes[holder.Type].Remove(holder);
                            unitNames.Remove(name);
                            Console.WriteLine(string.Format("SUCCESS: {0} removed!", name));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Format("FAIL: {0} could not be found!", name));
                        }
                        break;
                    case "find":
                        type = command[1];
                        Console.Write("RESULT: ");
                        if (unitTypes.ContainsKey(type))
                        {
                            Console.Write(string.Join(", ", unitTypes[type].Take(10)));
                        }
                        Console.WriteLine();
                        break;
                    case "power":
                        Console.WriteLine("RESULT: " + string.Join(", ", units.Take(int.Parse(command[1]))));
                        break;
                }
            }
        }
    }
}