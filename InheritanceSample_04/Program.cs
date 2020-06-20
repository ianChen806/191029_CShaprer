using System;

namespace InheritanceSample_04
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
        private string _name = "BaseBase";

        public MyClassBaseBase()
        {
            Console.WriteLine("BaseBase");
        }
    }

    internal class MyClassBase : MyClassBaseBase
    {
        private string _name = "Base";

        public MyClassBase()
        {
            Console.WriteLine("Base");
        }
    }

    internal class MyClassDerived : MyClassBase
    {
        private string _name = "Derived";

        public MyClassDerived()
        {
            Console.WriteLine("Derived");
        }
    }
}