/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
*/
using System;
class KadaneAlgorithm
{
    static void Main()
    {
        int[] array = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int currentMaxLength = 1;
        int maxLength = 1;
        int currentMaxSum = array[0];
        int maxSum = array[0];
        int start = 0;
        int finish = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (currentMaxSum + array[i] > array[i])
            {
                currentMaxSum = array[i] + currentMaxSum;
                currentMaxLength++;
            }
            else
            {
                currentMaxLength = 1;
                currentMaxSum = array[i];
                start = i;
            }
            if (currentMaxSum > maxSum)
            {
                maxSum = currentMaxSum;
                maxLength = currentMaxLength;
                finish = start;
            }
        }

        for (int i = finish; i < finish + maxLength; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}