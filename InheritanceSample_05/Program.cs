namespace InheritanceSample_05
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassDerived1 derived1 = new MyClassDerived1();
            MyClassBase myClass1 = derived1;

            MyClassBase myClassBase = Test(derived1);
            MyClassBase myClassBase2 = Test2(derived1);

            MyClassDerived2 derived2 = new MyClassDerived2();

            // MyClassDerived1 = derived2;
        }

        private static MyClassBase Test(MyClassBase myClass)
        {
            return myClass;
        }

        private static MyClassBase Test2(MyClassDerived1 derived1)
        {
            return derived1;
        }
    }

    class MyClassBase
    {
        public string Name { get; set; }
    }

    class MyClassDerived1 : MyClassBase
    {
    }

    class MyClassDerived2 : MyClassBase
    {
    }
}
