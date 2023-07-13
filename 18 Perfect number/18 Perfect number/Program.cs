using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {// let know the user to enter a number 
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            //Check if the number is perfect
            bool isPerfect = IsPerfectNumber(number);
            //display the result
            if (isPerfect)
            {
                Console.WriteLine(number + " is a perfect number.");
            }
            else
            {
                Console.WriteLine(number + " is not a perfect number.");
            }
            Console.ReadKey();
        }
        static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            // Find the divisors of the number and calculate their sum
             for (int i=1;i< number; i++ )
            {
                if(number % i==0)
                {
                    sum += i;
                }
            }
            // Check if the sum of divisor is equal to the number 
            return sum == number;
        }

    }
}
