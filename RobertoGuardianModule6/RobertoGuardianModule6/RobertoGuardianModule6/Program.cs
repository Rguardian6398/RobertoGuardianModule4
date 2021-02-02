using System;
using System.Collections.Generic;

namespace RobertoGuardianModule6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("The array has a length of: " +
                               myArray.Length);

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            List<string> myList = new List<string>();
            myList.Add("Value1");
            myList.Add("Value2");
            myList.Add("Value3");
            myList.Add("Value4");
            myList.Add("Value5");
            myList.Add("Value6");
            myList.Add("Value7");
            myList.Add("Value8");
            myList.Add("Value9");
            myList.Add("Value10");

            Console.WriteLine("The list has a length of: " +
                               myList);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}