using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_FIND_logest_common_sequence
{
    class Program
    {static String FindLongestCommonSubsequence(String str1,String str2)
        {
            int m = str1.Length;
            int n = str2.Length;
            //creat a dynamic programming table
            int[,] dp = new int[m + 1, n + 1];
            //building a dynamic programming table
            for (int i = 1; i<= m;i++)
            {
                for (int j=1;j<=n;j++)
                {
                 if(str1[i-1]==str2[j-1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                 else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                
                        
                }
            }
            // back tracking to find logest common sequence 
            String longestSubsequence = "";
            int row = m, col = n;
            while(row>0 && col>0)
            {
                if(str1[row-1]==str2[col-1])
                {
                    longestSubsequence = str1[row - 1] + longestSubsequence;
                    row--;
                    col--;
                }
                else if(dp[row-1,col] > dp[row,col-1])
                {
                    row--;
                }
                else
                {
                    col--;
                }
            }
            return longestSubsequence;
        }
        static void Main(string[] args)
        {// let know the user to enter 1st string
            Console.WriteLine("Enter 1st string:");
            String str1 = Console.ReadLine();
           // let know the user to enter 2st string
            Console.WriteLine("Enter 2st string:");
            String str2 = Console.ReadLine();
            //Find the longest common sequence
            String longestSubsequence = FindLongestCommonSubsequence(str1,str2);
            //display longest common sequence
            Console.WriteLine(longestSubsequence+" is longest common sequence");
            Console.ReadKey();
        }
    }
}
