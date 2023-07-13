using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        { // let know the user to enter a string 
            Console.WriteLine("Enter a string:");
            //Read the user input and store in a variable
            String input = Console.ReadLine();
           //call the Reverse method to reverse the string
         string reversed = Reverse(input);
           //display the reverse string
           Console.WriteLine("Reversed string: " + reversed);
            Console.ReadKey();
        }
        static string Reverse(string str)
        {
            //convert the input string  to character array
            char[] charArray = str.ToCharArray();
            //reverse the character array
            Array.Reverse(charArray);
            return new string(charArray);

        }
    }
}
