using System;

namespace InheritanceSample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass2 = new MyClass2();

            Console.WriteLine(myClass2.Name());
        }
    }

    class MyClass1
    {
        public string Name()
        {
            return "Name";
        }
    }

    class MyClass2 : MyClass1
    {
    }
}