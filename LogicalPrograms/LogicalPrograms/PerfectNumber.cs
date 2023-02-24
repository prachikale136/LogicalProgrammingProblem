using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public static void IsPerfect()
        {
            Console.WriteLine("Enter the number to check");
            int input = Convert.ToInt32(Console.ReadLine());

            int accumulator = 0;
            for (int i = 0; i < input; i++)
            {
                if (input % i == 0)
                {
                    accumulator += 1;
                }
            }
            if (accumulator == input)
            {
                Console.WriteLine("The number is perfect");
            }
            else 
            {
                Console.WriteLine();
            }
        }
    }
}
