using System;

namespace InterfaceSample_8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            IMyInterface1 myClass2 = myClass;
            var name1 = myClass2.Name();
            Console.WriteLine(name1);

            IMyInterface2 myClass3 = myClass;
            var name2 = myClass3.Name();
            Console.WriteLine(name2);
        }
    }

    interface IMyInterface1
    {
        string Name();
    }

    interface IMyInterface2
    {
        int Id { get; set; }

        string Name();
    }

    public class MyClass : IMyInterface1, IMyInterface2
    {
        public int Id { get; set; }

        string IMyInterface2.Name()
        {
            return "Name2";
        }

        string IMyInterface1.Name()
        {
            return "Name1";
        }
    }
}