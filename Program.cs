using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheckSubarraySum(new int[] { 23, 2, 4, 6, 7 }, 6));
        Console.WriteLine(CheckSubarraySum(new int[] { 23, 2, 6, 4, 7 }, 6));
        Console.WriteLine(CheckSubarraySum(new int[] { 23, 2, 6, 4, 7 }, 13));
        Console.WriteLine(CheckSubarraySum(new int[] { 1, 2, 3, 4 }, 6));
    }

    public static bool CheckSubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> remainders = new Dictionary<int, int>();

        int currentSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
            int remainder = currentSum % k;

            if (currentSum % k == 0 && i>= 1)
                return true;

            if (!remainders.ContainsKey(remainder))
            {
                remainders[remainder] = i;
               
            }
            else if (i - remainders[remainder] > 1)
            {
                return true;
            }
        }

        return false;
    }
}
