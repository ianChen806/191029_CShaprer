using System;

namespace TypeConvertSample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassBase myClass1 = new MyClass1();

            var myClass2 = (MyClass2)myClass1;

            var myClass3 = myClass1 as MyClass2;
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