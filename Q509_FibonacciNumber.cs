namespace Leetcode;

// Tag: dynamic programming

// The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones,
// starting from 0 and 1. That is,
// F(0) = 0, F(1) = 1
// F(n) = F(n - 1) + F(n - 2), for n > 1.
// Given n, calculate F(n).

//0 1 1 2 3 5 8
public class Q509_FibonacciNumber
{
    public static int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int i = 0;
        int j = 1;
        int k = 1;

        for (int l = 2; l < n; l++)
        {
            i = j;
            j = k;
            k = i + j;
        }

        return k;
    }
}