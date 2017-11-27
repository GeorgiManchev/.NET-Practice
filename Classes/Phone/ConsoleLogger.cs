using System;

namespace Phone
{
    public class ConsoleLogger : ILogger
    {
        private static ConsoleLogger consoleLogger = new ConsoleLogger();

        private ConsoleLogger() { }
        
        public static ConsoleLogger GetInstance()
        {
            return consoleLogger;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
