namespace Leetcode;

// Array, Dynamic Planning
public class Q121_BestTimeToBuyAndSellStock
{
    public static void Test()
    {
        int[] arr1 = new int[] { 1 };
        Console.WriteLine(
            $"Testing {ArrayUtil.DebugArray(arr1)}. Expect: 0. Actual: {MaxProfit(arr1)}.");
        
        int[] arr2 = new int[] { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(
            $"Testing {ArrayUtil.DebugArray(arr2)}. Expect: 5. Actual: {MaxProfit(arr2)}.");


        int[] arr3 = new int[] { 7, 2, 5, 1, 3 };
        Console.WriteLine(
            $"Testing {ArrayUtil.DebugArray(arr3)}. Expect: 3. Actual: {MaxProfit(arr3)}.");

        int[] arr4 = new int[] { 5, 5, 5, 8, 6, 10 };
        Console.WriteLine(
            $"Testing {ArrayUtil.DebugArray(arr4)}. Expect: 5. Actual: {MaxProfit(arr4)}.");
        
        int[] arr5 = new int[] { 3,5,1,7,8 };
        Console.WriteLine(
            $"Testing {ArrayUtil.DebugArray(arr5)}. Expect: 7. Actual: {MaxProfit(arr5)}.");
    }
    
    // Solution 1: loop through the prices array once.
    // Condition:
    // 1. The date we buy must be before the the date we sell.
    // 2. Price on sell day > price on buy day.
    public static int MaxProfit(int[] prices)
    {
        int lowest = int.MaxValue;
        int profit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            // If there is a new lowest value, store it and skip profit evaluation
            // because new lowest - old lowest < 0 which means no profit.
            
            // If the current value is higher:
            //          Compare the potential profit.
            //          If the profit just calculated is higher, store it. 
            // If the value is equal to the current lowest:
            //          no need to calculate the profit because it is 0, which equals to the default value of profit.)


            // Record the lowest number
            if (prices[i] < lowest)
            {
                lowest = prices[i];
            }
            // If the value is not the lowest, compute the profit.
            // If the profit is higher, record it.
            else if (prices[i] - lowest > profit)
            {
                // Because: prices[i] - prev lowest < prices[i] - mew lowest
                // So we don't need to worry that i
                profit = prices[i] - lowest;
            }
        }

        return profit;
    }
}