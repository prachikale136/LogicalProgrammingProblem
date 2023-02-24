using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void CheckPrime()
        {
            Console.WriteLine("Enter the to check Prime or not");  //take input from user
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;    //initialize isprime value as true
            if (number == 1)
            {
                Console.WriteLine("number is neither Prime Nor Composite");
            }
            else if (number > 1)
            { 
                for(int i=2; i< number; i++) 
                {
                    if (number % i == 0)   // check the condition {for ex 2%2 == 0} condition true
                    {
                        isPrime= false;    // It means if remainder is 0 then its not prime number and break the statement  
                        break;
                    }
                }
                if(isPrime)   // check if Isprime is true then its prime 
                {
                    Console.WriteLine("number is prime");
                }
                else 
                {
                    Console.WriteLine("number is not prime");    //otherwise it not prime number
                }
            }

        }
    }
}
