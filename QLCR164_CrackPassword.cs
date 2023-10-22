using System.Collections;
using System.Text;

namespace Leetcode;

// Greedy, Sorting, String
public class QLCR164_CrackPassword
{
    public static string CrackPassword(int[] password)
    {
        // We convert the entire int array to a list of string
        // because if the combination of two int exceed the range of int, it will cause problem.
        // If we convert all the int to string, we can concatenate the string and use the default string.CompareTo(string) to do comparison,
        // because the content of strings are all numbers. This approach prevents the too large number.
        
        
        List<string> list = new List<string>();

        foreach (var num in password)
        {
            list.Add(num.ToString());
        }
        
        list.Sort((x, y) => (x + y).CompareTo(y + x));

        StringBuilder stringBuilder = new StringBuilder();

        foreach (var num in list)
        {
            stringBuilder.Append(num);
        }

        return stringBuilder.ToString();
    }
}