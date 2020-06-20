using System;

namespace InheritanceSample_08
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            var name = myClass.Name();
            Console.WriteLine(name);
             
            MyClassBase myBase = new MyClass();
            var baseName = myBase.Name();
            Console.WriteLine(baseName);
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
        public new string Name()
        {
            return "Class";
        }
    }
}