using System;

namespace RobertoGuardianModule4
{
    class Program
    {
        static void Main()
        {
            DateTime myDateTimeVariable = new DateTime(2012,06,12);
            DateTime myDateTimeVariable2 = DateTime.Now;

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);


            Console.WriteLine(result);
        }
    }
}