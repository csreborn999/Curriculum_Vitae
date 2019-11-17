using System;
using System.Collections.Generic;
using System.Text;

/********************
 * 
 * The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
 * 
 * Given two integers x and y, calculate the Hamming distance.
 * 
 * Note: 0 ≤ x, y < 231.
 * 
 * Example:
 * Input: x = 1, y = 4
 * Output: 2
 * Explanation:
 * 1   (0 0 0 1)
 * 4   (0 1 0 0)
 *        ↑   ↑
 * The above arrows point to positions where the corresponding bits are different.
 *
 **********************/

namespace Leetcode_19_11_06
{
    class Leetcode_461
    {
        public int hammingDistance(int x, int y)
        {
            int xor = x ^ y, count = 0;
            while (xor != 0)
            {
                if ((xor & 1) == 1)
                    count++;
                xor >>= 1;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int x = 72, y = 122;
            Console.WriteLine(new Program().hammingDistance(x, y));
        }
    }
}
