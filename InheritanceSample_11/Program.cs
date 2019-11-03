using System;

namespace InheritanceSample_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal class MyClassBase
    {
        public virtual string Name()
        {
            return "Name";
        }
    }

    internal class MyClass : MyClassBase
    {
        public sealed override string Name()
        {
            return "Class";
        }
    }
}