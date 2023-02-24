using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        
        public static void IsReverse()
        {
            Console.WriteLine("Enter the number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10 ;
            }
            Console.WriteLine("Reverse no is :" +reverse);
            
        }
    }
}
