using System;

namespace InterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IMyInterface
    {
        string Property { get; set; }

        void Method();

        event EventHandler Event;

        string this[int index] { get; set; }
    }
}