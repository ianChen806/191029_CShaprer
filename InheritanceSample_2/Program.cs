using System;

namespace InheritanceSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
        }
    }

    internal class MyClass
    {
        public string Name()
        {
            return "Name";
        }
    }
}