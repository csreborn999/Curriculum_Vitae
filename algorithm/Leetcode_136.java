import java.util.*;

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

public class Leetcode_136 {
    public int singleNumber(int[] nums) {
        int diff = 0;
        for (int i: nums) {
            diff = diff ^ i;
        }
        return diff;
    }

    public static void main(String[] args) {
        int[] arr = { 4, 1, 2, 1, 2 };
        System.out.println(new Leetcode_136().singleNumber(arr));
    }
}
