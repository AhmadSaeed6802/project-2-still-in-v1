using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_mixer
{
    class Program
    {
        static void Main(string[] args)
        {
//1) Word Frequency Analysis
            // get the input text
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
            // Convert to array of words and display words  
            String[] wordsarray = ToWordsArray(text);
            // Calculate frequency of words 
            int[] counts = countFrequency(wordsarray);
            // Display frequency of words
            for (int i = 0; i <= wordsarray.Length - 1; i++)
            {
                Console.WriteLine("'{0}'  :{1} times", wordsarray[i], counts[i]);
            }
// 2). Generate 'N' sentences, each sentence containing 5 words chosen randomly from the array
            //Ask the user to input a number 'N'.
            Console.WriteLine("Enter the number ,how many random sentences you want");
            int number = Convert.ToInt32(Console.ReadLine());
            Random randomword = new Random();
            // numbers of sentences
            for (int i = 0; i < number; i++)
            {  //5 words sentence
                for (int j = 0; j <= 4; j++)
                {
                    int randomNumber = randomword.Next(0, wordsarray.Length - 1);
                    Console.Write(wordsarray[randomNumber] + " ");
                }
                Console.WriteLine();
            }

// 3) part longest and shortest words
            // longest in sentence
            String[] largest = new String[wordsarray.Length];
            largest[0] = wordsarray[0];
            int c = 0;
            for (int l = 0; l < wordsarray.Length; l++)
            {
                String str = wordsarray[l];
                if (wordsarray[l].Length > largest[0].Length)
                {
                    largest[0] = wordsarray[l];

                }
            }
            for (int l = 0; l < wordsarray.Length; l++)
            {
                if (wordsarray[l].Length == largest[0].Length)
                {
                    c += 1;
                    largest[c] = wordsarray[l];
                }
            }

            Console.WriteLine(" The largest words in text are: ");
            for (int i = 1; i <= c; i++)
            {
                Console.WriteLine(" " + largest[i]);
            }
            // shortest in sentence
            String[] shortest = new String[wordsarray.Length];
            shortest[0] = wordsarray[0];
            int d = 0;
            for (int l = 0; l < wordsarray.Length; l++)
            {
                if (wordsarray[l].Length < shortest[0].Length)
                {
                    shortest[0] = wordsarray[l];

                }
            }
            for (int l = 0; l < wordsarray.Length; l++)
            {
                if (wordsarray[l].Length == shortest[0].Length)
                {
                    d += 1;
                    shortest[d] = wordsarray[l];
                }
            }

            Console.WriteLine(" The smallest words in text are: ");
            for (int i = 1; i <= d; i++)
            {
                Console.WriteLine(" " + shortest[i]);
            }
//4) Search Word in text
            Console.WriteLine("Enter the word to search from text");
            String searched = Console.ReadLine();
            int counto = 0;
            for (int i = 0; i < wordsarray.Length; i++)
            {
                if (searched == wordsarray[i])
                {
                    counto++;
                }
            }
            Console.WriteLine("{0} is {1} times in the given text", searched, counto);
            if (counto == 0)
            {
                Console.WriteLine("so sorry {0} does not exist in the senence text", searched);
            }
//5)Check existaance of palidrome 
            int TotalNoOfPalidrome = 0;
            for (int i = 0; i < wordsarray.Length; i++)
            {
                bool ispalidrome = checkpalidrome(wordsarray[i]);
                if (ispalidrome)
                {
                    Console.WriteLine("{0} is palidrome", wordsarray[i]);
                    TotalNoOfPalidrome++;
                }

            }
            Console.WriteLine("total {0} palidrome are in text ", TotalNoOfPalidrome);

//6) vovals and consonants 
            VowelConsonantC0unt(wordsarray);
            Console.ReadKey();

        }


        // Method to convert a text to array of words
        static String[] ToWordsArray(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }

        //Method to count frequency of words 
        static int[] countFrequency(string[] wordsarray)
        {
            int[] countersArray = new int[wordsarray.Length];
            foreach (String word in wordsarray)
            {
                for (int i = wordsarray.Length - 1; i >= 0; i--)
                {                   // calculate the matching  number of elements
                    if (wordsarray[i] == word)
                    {
                        countersArray[i]++;
                    }
                }
            }
            return countersArray;
        }
        // method to check palidrom existances in a sentence text
        static bool checkpalidrome(String str)
        {
            int start = 0;
            int end = str.Length - 1;
            while (start < end)
            {
                if (str[start] != str[end])
                {
                    return false;
                }
                start += 1;
                end -= 1;
            }
            return true;
        }
        // mehtod for vowel and consonents count and display for every word in sentence
        static void VowelConsonantC0unt(string[] ArrayOfWords)
        {
            foreach (string word in ArrayOfWords)
            {
                string vowelsChar = "";
                string ConsonantChar = "";

                int vowel = 0;
                int Consonant = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                    {
                        vowel++;
                        vowelsChar += word[i];
                    }
                    else
                    {
                        Consonant++;
                        ConsonantChar += word[i];
                    }
                }

                string[] vowelsArray = vowelsChar.Split(',');
                string[] ConsonantArray = ConsonantChar.Split(',');

                Console.WriteLine($"The word {word} has {vowel} vowels :{string.Join(",", vowelsArray)} \n {Consonant} consonant: {string.Join(",", ConsonantArray)}");
            }

        }

    }

}