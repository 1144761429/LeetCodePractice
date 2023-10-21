using System.Collections;
using System.Text;

namespace Leetcode;

public abstract class ArrayUtil
{
    public static string DebugArray<T>(T[] arr)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("[");
        IEnumerator iterator = arr.GetEnumerator();
        iterator.MoveNext();
        foreach (var element in arr)
        {
            stringBuilder.Append($"{element?.ToString()}");
            if (iterator.MoveNext())
            {
                stringBuilder.Append($", ");
            }
        }
        stringBuilder.Append("]");
        return stringBuilder.ToString();
    }

    
    public static int[] FindMaxDiffSubArray_Negative(int[] arr)
    {
        int smallestValue = int.MaxValue;
        int difference = 0;

        int tempStartIdx = -1;
        int startIdx = -1;
        int endIdx = -1;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < smallestValue)
            {
                smallestValue = arr[i];
                tempStartIdx = i;
            }
            else if(arr[i] - smallestValue > difference)
            {
                difference = arr[i] - smallestValue;
                startIdx = tempStartIdx;
                endIdx = i;
            }
        }

        return new int[] { startIdx, endIdx };
    }
}