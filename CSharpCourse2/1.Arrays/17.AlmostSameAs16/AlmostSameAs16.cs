/** Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
 * Find in the array a subset of K elements that have sum S or indicate about its absence.
*/
using System;
class AlmostSameAs16
{
    static void Main()
    {
        Console.Write("Write length of the array: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrLength];
        int counterForSums = 0;
        Console.Write("Sum that we want: ");
        int sum = int.Parse(Console.ReadLine());
        Console.Write("Number of elements from which we want to get the sum(K): ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} elemen: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int maxRotationOfCycle = (int)Math.Pow(2, arrLength);

        for (int i = 1; i < maxRotationOfCycle - 1; i++)
        {
            int currentSum = 0;
            int currentK = 0;
            for (int j = 0; j < arrLength; j++)
            {
                int bit = ((1 << j) & i) >> j;
                if (bit == 1)
                {
                    currentSum += numbers[j];
                    currentK++;
                    if (currentK == k)
                    {
                        break;
                    }
                }
            }
            if (currentSum == sum)
            {
                if (currentK == k)
                {
                    counterForSums++;
                }   
            }
        }
        if (counterForSums != 0)
        {
            Console.WriteLine("There have the sum that we want with {0}(k) elements", k);
        }
        else
        {
            Console.WriteLine("There maybe have the sum that we want but its not with {0}(k) elements", k);
        }
    }
}