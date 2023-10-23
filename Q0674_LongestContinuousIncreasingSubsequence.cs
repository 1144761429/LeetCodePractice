namespace Leetcode;

// Tag: dynamic programming
public class Q0674_LongestContinuousIncreasingSubsequence
{
    // 状态转移公式：
    // if arr[i] < arr[i + 1]
    //      LCIS at i = (LCIS at i + 1) + 1 
    // if arr[i] >= arr[i + 1]
    //      LCIS at i = 1 
    public static int FindLengthOfLCIS(int[] nums)
    {
        int[] arr = new int[nums.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = 1;
        }

        for (int i = nums.Length - 1; i > 0; i--)
        {
            // If the number at i-1 is smaller than i,
            // then the longest continuous increasing subsequence at from (i - 1) to (nums.Length - 1) will be 1 + arr[i]
            if (nums[i - 1] < nums[i])
            {
                arr[i - 1] = arr[i] + 1;
            }
        }

        return arr.Max();
    }
}