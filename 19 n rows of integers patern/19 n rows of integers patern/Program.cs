using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_n_rows_of_integers_patern
{
    class Program
    {
        static void Main(string[] args)
        {       //  know the user to enter the number of rows 
            Console.WriteLine("Enter the number of rows");
            int n = int.Parse(Console.ReadLine());
            // Print the pattern up to n rows
            PrintPattern(n);
        }
        // prints the pattern to n rows
        static void PrintPattern(int n)
        {
            // iterate from 1 to n
            for (int i=1;i<=n;i++)
            {     // Print number from 1 to i on each row
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
