using System;

namespace InterfaceSample_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
        }
    }

    interface IMyInterface1
    {
        string Name();
    }

    interface IMyInterface2
    {
        int Id { get; set; }

        string Name();
    }

    internal class MyClass : IMyInterface1, IMyInterface2
    {
        public int Id { get; set; }

        string IMyInterface2.Name()
        {
            return "2";
        }

        string IMyInterface1.Name()
        {
            return "Name1";
        }
    }
}