namespace Leetcode;

/*
 * Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
 * The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 * You must write an algorithm that runs in O(n) time and without using the division operation.
 *
 * Example 1:
 * Input: nums = [1,2,3,4]
 * Output: [24,12,8,6]
 *
 * Example 2:
 * Input: nums = [-1,1,0,-3,3]
 * Output: [0,0,9,0,0]
 */

//Tag: Array, Prefix Sum, Dynamic Planning

public class Q238_ProductOfArrayExceptSelf
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] answer = new int[nums.Length];

        // This int helps to record the the product of number on the left of i.
        // The initial value is set to 1 but not 0 because this is multiplication, not addition.
        int tempProduct = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = tempProduct; // The product of numbers on the left of nums[i]
            tempProduct *= nums[i]; // The product of numbers from index 0 to i.
        }

        // At this moment, answer[] stores the product of all the numbers on the left of i;

        // Reset the int to 1 and do the same procedure from rightmost to the leftmost.
        tempProduct = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= tempProduct; // The product of numbers on the right of nums[i]
            tempProduct *= nums[i]; // The product of numbers from index[nums.Length - 1] to i
        }

        return answer;
    }
}

// Insights: The product of all the numbers in an array except i = the product of numbers on the left of i * the product of numbers on the right of i
// The product except self at i = the product of number except self at (i - 1) * (i - 1) + the product of number except self at (i + 1) * (i + 1)