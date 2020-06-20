using System;

namespace InheritanceSample_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClassDerived = new MyDerived();
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

    internal class MyDerived : MyClassBase
    {
        public MyDerived()
        {
            Console.WriteLine("Derived");
        }
    }
}