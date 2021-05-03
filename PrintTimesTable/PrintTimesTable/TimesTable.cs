using System;
using System.Collections.Generic;
using System.Text;

namespace PrintTimesTable
{
    class TimesTable
    {
        public static void timesTable(byte Number) // The function to show the times table
        {
            Console.WriteLine($"This is {Number} times table:");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{Number} x {i} = {Number * i}");
            }
        }

        public static void RunTimesTable()
        {
            while (true)
            {
                Console.Write("Please, enter a number: ");
                try
                {
                    byte Number = byte.Parse(Console.ReadLine());
                    timesTable(Number);
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }


                Console.WriteLine("Do you want to terminate the program?"); // A condition to terminate the program 

                Console.WriteLine("(1) Yes.");
                Console.WriteLine("(2) No.");

                byte condition = byte.Parse(Console.ReadLine());

                switch (condition)
                {
                    case 1:
                        continue;
                    case 2:
                        return;
                    default:
                        continue;
                }
            }
        }
    }
}
