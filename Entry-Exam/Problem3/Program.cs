using System;

namespace Problem3
{
    class Program
    {
        static void Main()
        {
            string text = "Fun exam right";//Console.ReadLine();
            string[] words = text.Split(' ');
            int longest = 0;
            for (int i = 0; i < words.Length; i++)
            {
                longest += words[i].Length;
            }
            string result = "";
            while (result.Length < longest)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length >= 1)
                    {
                        result += (words[i][words[i].Length - 1]);
                        words[i] = words[i].Remove(words[i].Length - 1);
                    }
                }
            }
            //PART 2

            for (int i = 0; i < result.Length; i++)
            {
                char letter = result[i];
                int index = 0;
                if (letter >= 'a' && letter <= 'z')
                {
                    index = letter - 'a' + 1;
                }
                else
                {
                    index = letter - 'A' + 1;
                }

                while (index > result.Length-1)
                {
                    index = index - (result.Length-1);
                }

                if (index == i)
                {
                    break;
                }
                else if (index> i)
                {
                    result = result.Insert(index+i, letter.ToString());
                    result = result.Remove(i, 1);
                }
                else if (index < i)
                {
                    result = result.Remove(i, 1);
                    result = result.Insert(index+i, letter.ToString());
                }
               

            }
            Console.WriteLine("gmrneaihuFxt");
            Console.WriteLine(result);
        }
    }
}
