using System;
using System.IO;

namespace InterfaceSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger1 = new ConsoleLogger();

            ConsoleLogger consoleLogger2 = new ConsoleLogger();

            ILogger consoleLogger3 = new ConsoleLogger();
            ILogger consoleLogger4 = new FileLogger();
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
            _name = $"Console.{name}";
        }
    }

    class FileLogger : ILogger
    {
        private string _name;

        public void Log(string message)
        {
            File.WriteAllText($"D://{_name}", message);
        }

        public void SetName(string name)
        {
            _name = $"File.{name}";
        }
    }
}