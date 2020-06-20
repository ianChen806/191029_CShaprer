using System;

namespace InheritanceSample_07
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            var name = myClass.Name();
            Console.WriteLine(name);
           
        }
    }

    internal class MyClassBase
    {
        public virtual string Name()
        {
            return "Base";
        }
    }

    internal class MyClass : MyClassBase
    {
        public string Name()
        {
            return "Class";
        }
    }
}