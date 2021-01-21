using System;

namespace RobertoGuardianModule4
{
    class Program
    {
        static void Main()
        {
            DateTime myDateTimeVariable = new DateTime(2020,12,10);
            DateTime myDateTimeVariable2 = new DateTime(2001, 12, 10);

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);


            Console.WriteLine(result);
        }
    }
}