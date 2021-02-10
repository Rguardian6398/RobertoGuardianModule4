using System;

namespace RobertoGuardianModule8
{
    class Program
    {
        static void Main()
        {
            MyClass<int> myClass = new MyClass<int>();

            myClass.MyProperty1 = 10;
            myClass.MyProperty2 = 20;

            Console.WriteLine(myClass.MyProperty1);
            Console.WriteLine(myClass.MyProperty2);


            MyClass<string> myClass2 = new MyClass<string>();

            myClass2.MyProperty1 = "string 1";
            myClass2.MyProperty2 = "string 2";

            Console.WriteLine(myClass2.MyProperty1);
            Console.WriteLine(myClass2.MyProperty2);

        }
    }
}
            public class MyClass<T>
            { 
              public T MyProperty1 { get; set; }
              public T MyProperty2 { get; set; }
            }