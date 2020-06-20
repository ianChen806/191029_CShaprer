using System;

namespace TypeConvertSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            var myService = new MyService();

            Notify(myClass);
            Notify(myService);
        }

        private static void Notify(MyBase myClass)
        {
            myClass.SendNotify();
            if (myClass is ILog log)
            {
                log.Log("message");
            }
        }
    }

    interface ILog
    {
        void Log(string message);
    }

    internal class MyBase
    {
        public void SendNotify()
        {
            Console.WriteLine("notify");
        }
    }

    class MyClass : MyBase
    {
    }

    class MyService : MyBase, ILog
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}