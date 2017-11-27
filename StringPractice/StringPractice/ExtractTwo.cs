using System;
using System.Text;

namespace StringPractice
{
    public class ExtractTwo
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            var sentences = Console.ReadLine().Split(".".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var result = new StringBuilder();
            foreach (var sentence in sentences)
            {
                var words = sentence.Split(" `~1234567890-=!@#$%^&*()_+[]\\{}|;:<>'\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    if (word == keyWord)
                    {
                        result.Append(sentence.Trim() + ". ");
                        break;
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}