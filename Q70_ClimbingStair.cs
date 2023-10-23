namespace Leetcode;

//Tag: dynamic programming

// You are climbing a staircase. It takes n steps to reach the top.
// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

// Example 1:
//
// Input: n = 2
// Output: 2
// Explanation: There are two ways to climb to the top.
// 1. 1 step + 1 step
// 2. 2 steps

// Example 2:
//
// Input: n = 3
// Output: 3
// Explanation: There are three ways to climb to the top.
// 1. 1 step + 1 step + 1 step
// 2. 1 step + 2 steps
// 3. 2 steps + 1 step

public class Q70_ClimbingStair
{
    public static int ClimbStairs(int n)
    {
        int i = 0;
        int j = 0;
        int k = 1;
        
        for (int count = 0; count < n; count++)
        {
            i = j;
            j = k;
            k = i + j;
        }
        
        return k;
    }
}