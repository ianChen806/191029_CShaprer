using System;

namespace InheritanceSample_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal abstract class MyClassBase
    {
        protected abstract string Name();
    }
}