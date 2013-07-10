/*Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * Find in the array those K elements that havemaximal sum.
*/
using System;
using System.Collections.Generic;
class MaximalSum
{
    static void Main()
    {
        Console.Write("Write N:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write K: ");
        int k = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int[] biggestNumbers = new int[k];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - k; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < k; j++)
            {
                currentSum += numbers[i + j];
            }
            if (currentSum > sum)
            {
                sum = currentSum;
                for (int j = 0; j < k; j++)
                {
                    biggestNumbers[j] = numbers[i + j];
                }
            }
        }
        Console.WriteLine("Highest sum of K elements ({0}) is : {1}", k, sum);
        Console.Write("Biggest elements are: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(biggestNumbers[i] + " ");
        }
        Console.WriteLine();
    }
}