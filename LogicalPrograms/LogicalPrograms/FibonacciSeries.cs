using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public static int previous = 0;
        public static int previousToPrevious = 1;
        public static int nextTerm;
        public static void GetSeries()
        {

            Console.WriteLine("Enter the number to series");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                nextTerm = previous + previousToPrevious;
                previous = previousToPrevious;
                previousToPrevious = nextTerm;

                Console.WriteLine(nextTerm);
            }

        }
    }
}
