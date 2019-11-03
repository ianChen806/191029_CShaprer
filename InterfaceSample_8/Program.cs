using System;

namespace InterfaceSample_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            // Console.WriteLine(myClass.Name);

            IMyInterface myClass2 = myClass;
            Console.WriteLine(myClass2.Name);

            IMyInterface2 myClass3 = myClass;
            Console.WriteLine(myClass3.Name);
        }
    }

    interface IMyInterface
    {
        string Name { get; set; }
    }

    interface IMyInterface2
    {
        int Id { get; set; }

        string Name { get; set; }
    }

    public class MyClass : IMyInterface, IMyInterface2
    {
        private string _name2;
        private string _name1;

        public int Id { get; set; }

        string IMyInterface.Name
        {
            get => "Name1";
            set => _name1 = value;
        }

        string IMyInterface2.Name
        {
            get => "Name2";
            set => _name2 = value;
        }
    }
}