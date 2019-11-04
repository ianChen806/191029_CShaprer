using System;

namespace InheritanceSample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var derivedClass = new MyDerivedClass();

            var name = derivedClass.Name();
            Console.WriteLine(name);

            var test = derivedClass.Test();
        }
    }

    class MyBaseClass
    {
        public string Name()
        {
            return "Name";
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        public string Test()
        {
            return "Derived";
        }
    }
}