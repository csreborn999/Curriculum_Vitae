using System;
using System.Collections.Generic;
using System.Text;

/********************
 * 
 * Given a positive integer, output its complement number. The complement strategy is to flip the bits of its binary representation.
 * Note:
 * The given integer is guaranteed to fit within the range of a 32-bit signed integer.
 * You could assume no leading zero bit in the integer’s binary representation.
 * 
 * Example 1:
 * Input: 5
 * Output: 2
 * Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.
 * 
 **********************/

namespace Leetcode_19_11_06
{
    class Leetcode_476
    {
        public int findComplement(int num)
        {
            int convert = 1, temp = num / 2;
            while (temp > 0)
            {
                temp /= 2;
                convert = convert * 2 + 1;
            }
            return num ^ convert;
        }

        static void Main(string[] args)
        {
            int num = 20;
            Console.WriteLine(new Program().findComplement(num));
        }
    }
}
