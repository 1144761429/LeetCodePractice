using System.Text;

namespace Leetcode;

public abstract class Util
{
    public static string DebugArray<T>(T[] arr)
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (T element in arr)
        {
            stringBuilder.Append(element?.ToString() + " ");
        }

        return stringBuilder.ToString();
    }
}