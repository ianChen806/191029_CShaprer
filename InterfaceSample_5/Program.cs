using System;

namespace InterfaceSample_5
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface myClass = new MyClass();
            myClass.Name2 = "Name";
            Console.WriteLine(myClass.Name2);
        }
    }

    interface IMyInterface
    {
        string Name2 { get; set; }
    }

    class MyClass : IMyInterface
    {
        public string Name2 { get; set; }
    }
}
