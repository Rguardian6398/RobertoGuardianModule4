using System;

namespace RobertoGuardianModule9
{
    class Program
    {
        static void Main()
        {
            MyClass myVariable = new MyClass();
            myVariable.MyMethod<string>("string 1", "string 2");

            Console.WriteLine(myVariable.MyProperty1);
            Console.WriteLine(myVariable.MyProperty2);
        }
    }
}

public class MyClass
{
    public string MyProperty1 { get; set; }
    public string MyProperty2 { get; set; }

    public void MyMethod<T>(T parameter1, T parameter2)
    {
        this.MyProperty1 = parameter1.ToString();
        this.MyProperty2 = parameter2.ToString();
    }
}