using System;
using anotherNameSpace;

namespace cap1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var dorayaki = new Product(98, "どら焼き", 210);

            Console.WriteLine(dorayaki.GetTax());
            //Console.ReadLine();


            //問題１．２

            var a = new MyClass();
            var b = new MyStruct();
            a.X = 20;
            a.Y = 16;
            b.X = 20;
            b.Y = 16;

            PrintObjects(a, b);
            Console.WriteLine(a.X + " " + a.Y);
            Console.WriteLine(b.X + " " + b.Y);
            //Console.ReadLine();


            var yamada = new Student
            {
                Name = "Yamada",
                Birthday = new DateTime(1972, 07, 14),
                Grade = 1,
                ClassNumber = 2,

            };

            var c = new object();
            c = yamada;

            var d = new Person();
            d = yamada;

            object e = yamada;
            Person f = yamada;



            Console.WriteLine(yamada.Name + " " + yamada.Birthday + " " + yamada.Grade + " " + yamada.ClassNumber);
            Console.ReadLine();

        }

        internal static void PrintObjects(MyClass myclass,MyStruct mystruct)
        {
            Console.WriteLine(myclass.X + " " + myclass.Y);
            Console.WriteLine(mystruct.X + " " + mystruct.Y);
            Console.ReadLine();


            myclass.X = myclass.X * 2;
            myclass.Y = myclass.Y * 2;

            mystruct.X = mystruct.X * 2;
            mystruct.Y = mystruct.Y * 2;




        }
    }
}
