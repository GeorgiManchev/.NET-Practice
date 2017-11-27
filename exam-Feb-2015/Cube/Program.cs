using System;

namespace Cube
{
    static class ExtensionChar
    {
        public static void draw(this char symbol, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(symbol);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //input
            char space = ' ', colon = ':', top = '/', side = 'X';

            space.draw(n-1); colon.draw(n); Console.WriteLine(); //first row
            space.draw(n - 2); colon.draw(); top.draw(n - 2); colon.draw(2); Console.WriteLine(); //second row
            //sides
            for (int i = 0; i < n-3; i++)
            {
                space.draw(n - i-3); colon.draw(); top.draw(n-2); colon.draw(); side.draw(i + 1); colon.draw();
                Console.WriteLine();
            }
            colon.draw(n); side.draw(n - 2); colon.draw(); Console.WriteLine(); //top front

            for (int i = 0; i < n - 3; i++)
            {
                colon.draw(); space.draw(n - 2); colon.draw(); side.draw(n - i - 3); colon.draw();
                Console.WriteLine();
            }
            colon.draw(); space.draw(n - 2); colon.draw(2);
            Console.WriteLine();
            colon.draw(n); // last row
            Console.WriteLine();
        }
    }
}
