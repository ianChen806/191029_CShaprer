using System;
using System.Reflection.Metadata.Ecma335;

namespace TypeConvertSample_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass()
            {
                Id = "Guid",
                Name = "Name",
                Type = 1,
            };
            if (myClass is {})
            {
                Console.WriteLine("not null");
            }

            MyClass myNullClass = null;
            if (myNullClass is {})
            {
                Console.WriteLine("not null");
            }

            if (myClass is {Id: var id, Name: var name, Type: 1})
            {
                Console.WriteLine($"{id}_{name}");
            }

            if (myClass is (var id2, var name2, 1))
            {
                Console.WriteLine($"{id2}___{name2}");
            }

            myClass = new MyClass()
            {
                Id = "Guid",
                Name = "Name",
                Type = 1,
                InnerType = new MyClass()
                {
                    Type = 5
                }
            };
            if (myClass is (var id3, var name3, 1, {Type: 5}))
            {
                Console.WriteLine($"{id3}___{name3}___inner:5");
            }
        }
    }

    class MyClass
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public MyClass InnerType { get; set; }

        public void Deconstruct(out string id, out string name, out int type)
        {
            id = Id;
            name = Name;
            type = Type;
        }

        public void Deconstruct(out string id, out string name, out int type, out MyClass innerType)
        {
            id = Id;
            name = Name;
            type = Type;
            innerType = InnerType;
        }
    }
}