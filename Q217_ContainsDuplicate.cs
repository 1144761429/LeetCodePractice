namespace Leetcode;

// Array, Hashtable, Sorting
public class Q217_ContainsDuplicate
{
    // Given an integer array nums,
    // return true if any value appears at least twice in the array,
    // and return false if every element is distinct.   
    
    // Constraints:
    //
    // 1 <= nums.length <= 105
    // -109 <= nums[i] <= 109
    public static bool ContainsDuplicate(int[] nums)
    {
        if (nums.Length == 1)
        {
            return false;
        }
        
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int element in nums)
        {
            if (!dict.TryAdd(element, 0))
            {
                return true;
            }
        }

        return false;
    }
}