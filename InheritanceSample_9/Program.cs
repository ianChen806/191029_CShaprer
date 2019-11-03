using System;

namespace InheritanceSample_9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            int name = myClass.Name("Test");

            Console.WriteLine(name);
        }
    }

    internal class MyClassBase
    {
        public virtual string Name(string value)
        {
            return "Base" + value;
        }
    }

    internal class MyClass : MyClassBase
    {
        public new int Name(string value)
        {
            return 1;
        }
    }
}