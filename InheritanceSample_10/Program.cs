using System;

namespace InheritanceSample_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal abstract class MyClassBase
    {
        protected abstract string Name();

        protected abstract void Notify(object id, string name);

        protected abstract string GetId(string name);

        public bool Run()
        {
            var name = Name();
            // ...
            var id = GetId(name);
            // ...
            Notify(id, name);
            // ...
            return true;
        }
    }
}