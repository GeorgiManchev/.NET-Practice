using System;
using System.Text;

namespace StringPractice
{
    public class UniCode
    {
        public static void Main()
        {
            var result = new StringBuilder();
            foreach (var item in Console.ReadLine())
            {
                result.Append("\\u");
                result.Append(string.Format(item.ToString(), "X4"));
            }
            Console.WriteLine(result);
        }
    }
}
