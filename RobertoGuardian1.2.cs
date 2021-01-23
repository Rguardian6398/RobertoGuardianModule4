using System;

namespace RobertoGuardianModule4
{
        class Program
        {
        static void Main()
        {
            DateTime myDateTimeVariable = new DateTime(2020, 12, 10);
            DateTime myDateTimeVariable2 = new DateTime(2001, 12, 10);

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);

            if (result == 1)
            {
                Console.WriteLine("First date is greater");
            }
            else
            {
                Console.WriteLine("Second date is greater");
            }
        }
        }
    }