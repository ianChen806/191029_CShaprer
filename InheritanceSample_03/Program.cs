using System;

namespace InheritanceSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClassDerived = new MyClassDerived();
        }
    }

    internal class MyClassBaseBase
    {
        public MyClassBaseBase()
        {
            Console.WriteLine("BaseBase");
        }
    }

    internal class MyClassBase : MyClassBaseBase
    {
        public MyClassBase()
        {
            Console.WriteLine("Base");
        }
    }

    internal class MyClassDerived : MyClassBase
    {
        public MyClassDerived()
        {
            Console.WriteLine("Derived");
        }
    }
}