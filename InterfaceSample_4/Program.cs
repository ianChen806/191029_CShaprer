using System;
using System.IO;

namespace InterfaceSample_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();

            ILogger fileLogger = Test(consoleLogger);

            fileLogger.Log("Test");
        }

        private static ILogger Test(ILogger logger)
        {
            logger.Log("Test");

            return new FileLogger();
        }
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.WriteAllText("D://Test.txt", message);
        }
    }

    interface ILogger
    {
        void Log(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}