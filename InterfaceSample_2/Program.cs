using System;

namespace InterfaceSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogger();
            consoleLogger.SetName("Test");
            consoleLogger.Log("Log");
        }
    }

    interface ILogger
    {
        void Log(string message);

        void SetName(string name);
    }

    class ConsoleLogger : ILogger
    {
        private string _name;

        public void Log(string message)
        {
            Console.WriteLine($"{_name} {message}");
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }
}