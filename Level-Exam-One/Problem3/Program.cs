using System;
using System.Collections.Generic;

namespace Problem3
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            List<string> variables = new List<string>();
            while (!text.EndsWith("{!}"))
            {
                int monkeyIndex = text.IndexOf('@');
                while (monkeyIndex != -1 && (text.IndexOf('\\') != monkeyIndex - 1 || text.IndexOf('\\') == -1) &&
                    ((text.IndexOf("//") == -1 && text.IndexOf("/*") == -1) ||
                    (IsCommentAfterIndex(text, "//", monkeyIndex) || IsCommentAfterIndex(text, "/*", monkeyIndex))))
                {
                    string variable = ExtractVariable(text.Substring(monkeyIndex));
                    if (!variables.Contains(variable))
                    {
                        variables.Add(variable);
                    }
                    monkeyIndex = text.IndexOf('@', monkeyIndex + 1);
                }
                text = Console.ReadLine();
            }
            variables.Sort();
            Console.WriteLine(variables.Count);

            foreach (var item in variables)
            {
                Console.WriteLine(item);
            }
        }

        private static bool IsCommentAfterIndex(string text, string comment, int index)
        {
            return (text.IndexOf(comment) > index);
        }

        private static string ExtractVariable(string text)
        {
            return text.Split(GetSeperators(text), StringSplitOptions.RemoveEmptyEntries)[0];
        }

        private static char[] GetSeperators(string text)
        {
            List<char> seperators = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                if (!seperators.Contains(current) &&
                    !Char.IsDigit(current) &&
                    !Char.IsLetter(current) &&
                    current != '_')
                {
                    seperators.Add(current);
                }
            }
            return seperators.ToArray();
        }
    }
}
