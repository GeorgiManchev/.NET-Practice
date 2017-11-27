using System;
using System.Linq;
using System.Text;

namespace Entry_Exam
{
    public class StringTask
    {

        //2^20 = 1 048 576 command calls
        //"start" + "mid" + "end"

        static void Main(string[] args)
        {
            int valueLength = 1048576;
            var command = Console.ReadLine().Split();
            StringBuilder ends = new StringBuilder(valueLength * 3, valueLength * 3);
            string midSection = string.Empty;
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "set":
                        if (command[1].Length >= valueLength * 2)
                        {
                            ends.Append(command[1].Substring(0, valueLength));
                            ends.Append(" "); //seperator
                            ends.Append(command[1].Substring(command[1].Length - 1 - valueLength, valueLength));
                            //set the mid section
                        }
                        break;
                    case "front-add":
                        if (ends.Length > 0)
                        {
                            ends.Insert(0, command[1]);
                        }
                        break;
                    case "front-remove":
                        if (ends.Length > 0)
                        {
                            ends.Remove(0, 1);
                        }
                        break;
                    case "back-add":
                        ends.Append(command[1]);
                        break;
                    case "back-remove":
                        ends.Remove(ends.Length - 1, 1);
                        break;
                    case "reverse":
                        if (ends.Length > 1)
                        {
                            var reversed = string.Join("", ends.ToString().Reverse());
                            ends.Clear();
                            ends.Append(reversed);
                        }
                        break;
                    case "print":
                        var holder = ends.ToString().Split();
                        Console.WriteLine("{0}{1}{2}", holder[0], midSection, holder[1]);
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
