using System;
using System.Collections.Generic;
using System.Text;

/*************************
 * 
 * Given two words word1 and word2, find the minimum number of operations required to convert word1 to word2.
 * You have the following 3 operations permitted on a word:
 * 1.Insert a character
 * 2.Delete a character
 * 3.Replace a character
 *
 * Example 1:
 *
 * Input: word1 = "horse", word2 = "ros"
 * Output: 3
 * Explanation: 
 * horse -> rorse (replace 'h' with 'r')
 * rorse -> rose (remove 'r')
 * rose -> ros (remove 'e')
 *************************/

namespace Leetcode_19_11_06
{
    class Leetcode_72
    {
        public int minDistance(String word1, String word2)
        {
            int n = word1.Length;
            int m = word2.Length;

            //if one of the strings is empty
            if (n * m == 0) return n + m;

            //array to store the convertion history
            int[,] d = new int[n + 1, m + 1];

            //init boundaries
            for (int i = 0; i < n + 1; i++)
                d[i, 0] = i;
            for (int j = 0; j < m + 1; j++)
                d[0, j] = j;

            //DP compute
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < m + 1; j++)
                {
                    int left = d[i - 1, j] + 1;
                    int down = d[i, j - 1] + 1;
                    int left_down = d[i - 1, j - 1];
                    if (word1[i - 1] != word2[j - 1]) left_down++;
                    d[i, j] = Math.Min(left, Math.Min(down, left_down));
                }
            }
            return d[n, m];
        }

        static void Main(string[] args)
        {
            String word1 = "house", word2 = "ros";
            Console.WriteLine("the minimum number of operations required to convert " + word1 + " to " + word2 + " is " + new Leetcode_72().minDistance(word1, word2));
        }
    }
}
