using System;

namespace RobertoGuardianModule5
{
    class Program
    {
        static void Main()
        {
            for (int x = 0; x < 21; x++)
          {
                Console.WriteLine("Line: " + x);
          }
            int sum = 21;

            for (int i = 0; i <= 21; i++)
            {
                sum += i;
            }

            Console.WriteLine("The result is: " + sum);
        }
    }
}