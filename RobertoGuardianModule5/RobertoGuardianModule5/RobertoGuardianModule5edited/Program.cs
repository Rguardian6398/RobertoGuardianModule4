using System;

namespace RobertoGuardianModule5edited
{
    class Program
    {
        static void Main()
        {
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                sum += i;
            }

            Console.WriteLine("The result is: " + sum);
        }
    }
}