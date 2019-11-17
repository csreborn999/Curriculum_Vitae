using System;
using System.Collections.Generic;
using System.Text;

/********************
 * 
 * Given a non-empty array of integers, every element appears twice except for one. Find that single one.
 * 
 * Note:
 * Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
 * Example 1:
 * Input: [2,2,1]
 * Output: 1
 *
 **********************/

namespace Leetcode_19_11_06
{
    class Leetcode_136
    {
        public int singleNumber(int[] nums)
        {
            int diff = 0;
            foreach (int i in nums)
            {
                diff = diff ^ i;
            }
            return diff;
        }

        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 2, 1, 2 };
            Console.WriteLine(new Program().singleNumber(arr));
        }
    }
}
