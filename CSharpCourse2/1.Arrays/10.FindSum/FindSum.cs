/*Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/
using System;
class FindSum
{
    static void Main()
    {
        int[] array = {1, 2, 3, 5, 6, -10 };
        int sum = 3;
        int start = 0;
        int finish = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum <= sum)
                {
                    if (currentSum == sum)
                    {
                        start = i;
                        finish = j - i;
                        i = array.Length;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        for (int i = start; i <= start + finish; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
