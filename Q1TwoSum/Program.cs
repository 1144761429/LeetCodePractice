namespace Leetcode.Q1TwoSum;

public class Program
{
    public static void Main(string[] args)
    {
        int[] result = TwoSum1(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine(Util.DebugArray(result)); // 0 1 

        int[] result2 = TwoSum1(new int[] { 3, 2, 4 }, 6);
        Console.WriteLine(Util.DebugArray(result2)); // 1 2 

        int[] result3 = TwoSum1(new int[] { 3, 3 }, 6);
        Console.WriteLine(Util.DebugArray(result3)); // 0 1
        
        int[] result4 = TwoSum1(new int[] { 2,4,11,3 }, 6);
        Console.WriteLine(Util.DebugArray(result4)); // 0 1
        
        int[] result5 = TwoSum1(new int[] { 1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1}, 11);
        Console.WriteLine(Util.DebugArray(result5)); // 5 11
    }
    
    // Solution One: using Dictionary
    public static int[] TwoSum1(int[] nums, int target)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++){
            int currentValue = nums[i];
            int need = target - currentValue;
        
            if (dict.ContainsKey(need))
            {
                return new int[] { dict[need], i };
            }
            
            // We only add the element into the dictionary when there is no duplicate in dictionary
            // because duplicate is redundant in this question.
            // For example: if [1, 1, 2] target 3
            // In this case any 1 plus 2 will get 3. It doesn't matter if we choose the first 1 or the second 1.
            // So, when there is a duplicate, just skip the addition to the dictionary of it.
            if (!dict.ContainsKey(currentValue))
            {
                dict.Add(nums[i], i);
            }
        }
        
        // The case if there is no solution.
        return new int[] { -1, -1 };
    }
    
    // Solution Two: using List
    public static int[] TwoSum2(int[] nums, int target)
    {
        List<int> list = new List<int>();

        for(int i = 0; i < nums.Length; i++){
            int currentValue = nums[i];
            int need = target - currentValue;

            if (list.Contains(need))
            {
                return new int[]{i, list.IndexOf(need)};
            }
            
            list.Add(currentValue);
        }
        
        // The case if there is no solution.
        return new int[]{-1, -1};
    }
}