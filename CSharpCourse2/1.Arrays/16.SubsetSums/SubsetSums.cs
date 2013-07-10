/** We are given an array of integers and a number S. Write a program to find if there
 * exists a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
*/
using System;
class SubsetSums
{
    static void Main()
    {
        Console.Write("Write length of the array: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrLength];

        Console.Write("Sum that we want: ");
        int sum = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} elemen: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int maxRotationOfCycle = (int)Math.Pow(2, arrLength);

        for (int i = 1; i < maxRotationOfCycle; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < arrLength; j++)
            {
                int bit = ((1 << j) & i) >> j;
                if (bit == 1)
                {
                    currentSum += numbers[j];
                }
            }
            if (currentSum == sum)
            {
                Console.Write("Yes(");
                for (int j = 0; j < arrLength; j++)
                {
                    int bit = ((1 << j) & i) >> j;
                    if (bit == 1)
                    {
                        Console.Write("{0}+", numbers[j]);
                    }
                }
                Console.Write("\b)");
                Console.WriteLine();
            }
        }
    }
}