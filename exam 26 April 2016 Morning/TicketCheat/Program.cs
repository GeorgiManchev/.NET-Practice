using System;
using System.Text;

namespace TicketCheat
{
    class Program
    {
        static void Main()
        {
            string perforator = Convert.ToString(int.Parse(Console.ReadLine()), 2);
            int m = int.Parse(Console.ReadLine());
            string[] result = new string[m];
            string perReplace = String.Empty;
            for (int i = 0; i < perforator.Length; i++)
            {
                perReplace += '0';
            }
            for (int i = 0; i < m; i++)
            {
                string binTicket = Convert.ToString(int.Parse(Console.ReadLine()), 2);

                StringBuilder builder = new StringBuilder(binTicket);
                while (binTicket.Contains(perforator))
                {
                    builder.Replace(perforator, perReplace, binTicket.LastIndexOf(perforator), perforator.Length);
                    binTicket = builder.ToString();
                }
                result[i] = binTicket;
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(Convert.ToInt32(result[i], 2));
            }
        }
    }
}
