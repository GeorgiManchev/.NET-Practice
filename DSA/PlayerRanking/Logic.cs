using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace PlayerRanking
{
    class Logic
    {
        static void Main()
        {
            var playersRanklist = new BigList<Player>();
            var typeToPlayerMap = new Dictionary<string, OrderedSet<Player>>();

            var args = Console.ReadLine().Split();
            while (args[0] != "end")
            {
                if (args[0] == "add")
                {
                    var name = args[1];
                    var type = args[2];
                    var age = int.Parse(args[3]);
                    var position = int.Parse(args[4]) - 1;

                    var player = new Player() { Name = name, Type = type, Age = age };

                    if (!typeToPlayerMap.ContainsKey(type))
                    {
                        typeToPlayerMap.Add(type, new OrderedSet<Player>());
                    }

                    typeToPlayerMap[type].Add(player);
                    playersRanklist.Insert(position, player);

                    Console.WriteLine(string.Format("Added player {0} to position {1}", player.Name, position + 1));
                }
                else if (args[0] == "find")
                {
                    var findType = args[1];
                    if (typeToPlayerMap.ContainsKey(findType))
                    {
                        var players = typeToPlayerMap[findType];

                        var result = $"Type {findType}: {string.Join("; ", players.Take(5))}";
                        result.TrimEnd(';', ' ');

                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine($"Type {findType}: ");
                    }
                }
                else if (args[0] == "ranklist")
                {
                    var start = int.Parse(args[1]) - 1;
                    var end = int.Parse(args[2]) - 1;
                    var count = end - start + 1;
                    var rankedPlayers = playersRanklist.Range(start, count);

                    var playerPosition = start + 1;
                    var rankingResult = string.Join("; ", rankedPlayers.Select(p => $"{playerPosition++}. {p}"));

                    rankingResult.TrimEnd(';', ' ');

                    Console.WriteLine(rankingResult);
                }

                args = Console.ReadLine().Split();
            }

        }
    }
}