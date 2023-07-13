using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_sorts_an_array
{
    class Program
    {
        static void Main(string[] args)
        {// let know the user to enter a number 
            Console.WriteLine("Enter a size of array");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            // Generate random numbers and populate the array( fill the array data structure with the set of vakues)
            Random random = new Random();
            for (int i=0;i<size;i++)
            {
            // generate the random numbers between 1 and 100
                numbers[i] = random.Next(100);
            }
            Console.WriteLine("Original Array:");
            PrintArray(numbers);
            // Sort array in ascending order 
            SortArray(numbers);

            Console.WriteLine("Sorted Array");
            PrintArray(numbers);
            Console.ReadKey();

        }
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void SortArray(int[] array)
        {
            //Use bubble sort algorithm to sort the array
            int n = array.Length;
            for (int i=0;i<n-1;i++)
            {
                for(int j=0;j<n-i-1;j++)
                {
                    if (array[j]>array[j+1])
                    {
                        // Swap elements if they are in the wrong order
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                }
            }
        }

    }
}
