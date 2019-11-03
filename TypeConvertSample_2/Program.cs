namespace TypeConvertSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassBase myClass1 = new MyClass1();

            var myClass2 = myClass1 as MyClass2;

            var myClass3 = myClass1 is MyClass2;
        }
    }

    internal class MyClassBase
    {
    }

    internal class MyClass1 : MyClassBase
    {
    }

    internal class MyClass2 : MyClassBase
    {
    }
}