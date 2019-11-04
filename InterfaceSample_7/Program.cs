namespace InterfaceSample_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
        }
    }

    interface IMyInterface1
    {
        string Name { get; set; }
    }

    interface IMyInterface2
    {
        int Id { get; set; }

        string Name { get; set; }
    }

    internal class MyClass : IMyInterface1, IMyInterface2
    {
        public int Id { get; set; }

        string IMyInterface2.Name { get; set; }

        string IMyInterface1.Name { get; set; }
    }
}