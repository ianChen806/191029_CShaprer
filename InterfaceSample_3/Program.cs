using System;
using System.IO;

namespace InterfaceSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger();

            //-----
            
            ILogger logger;
            logger = new ConsoleLogger();
            logger.Log("Test");

            logger = new FileLogger();
            logger.Log("Test1");
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
            Console.WriteLine($"{message}");
        }
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            var filePath = $"D://{DateTime.Now.Ticks}.log";
            File.WriteAllText(filePath, message);
        }
    }
}