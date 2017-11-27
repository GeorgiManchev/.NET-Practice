using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringPractice
{
    public class ExtractOne
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            var sentences = Console.ReadLine().Split(Seperators("."), StringSplitOptions.RemoveEmptyEntries);
            var result = new StringBuilder();
            foreach (var sentence in sentences)
            {
                var words = sentence.Split(Seperators(sentence), StringSplitOptions.RemoveEmptyEntries);

                if (words.Contains(keyWord))
                {
                    result.Append(sentence.Trim() + ". ");
                }
            }
            Console.WriteLine(result.ToString());
        }

        static char[] Seperators(string input)
        {
            return new HashSet<char>(input.Where(x => !char.IsLetter(x))).ToArray();
        }
    }
}
