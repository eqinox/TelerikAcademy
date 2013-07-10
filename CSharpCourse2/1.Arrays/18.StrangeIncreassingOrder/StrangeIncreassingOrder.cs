/** Write a program that reads an array of integers and removes from it a minimal number of elements in such way
 * that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
*/
using System;
using System.Collections.Generic;
class StrangeIncreassingOrder
{
    static int GetSmallestNumber(int[] arr)
    {
        int smallestNum = arr[0];
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < smallestNum)
            {
                smallestNum = arr[i];
                break;
            }
        }
        return smallestNum;
    }
    static int GetBiggestNumber(int[] arr)
    {
        int biggestNum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > biggestNum)
            {
                biggestNum = arr[i];
            }
        }
        return biggestNum;
    }
    static void Main()
    {
        Console.Write("Length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("{0} element: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int smallestNumber = GetSmallestNumber(numbers);
        int biggestNumber = GetBiggestNumber(numbers);
        int counterForNextNumber = 0;
        int counterWhichPositionToStart = 0;
        List<int> newArray = new List<int>();
        newArray.Add(smallestNumber);
        Console.WriteLine();
        for (int i = 0; i <= biggestNumber; i++)
        {
            counterForNextNumber++;
            for (int j = counterWhichPositionToStart; j < length; j++)
            {
                if (smallestNumber + counterForNextNumber == numbers[j])
                {
                    smallestNumber += counterForNextNumber;
                    newArray.Add(numbers[j]);
                    counterForNextNumber = 0;
                    counterWhichPositionToStart = j;
                    i = 0;
                }
            }
        }
        foreach (var item in newArray)
        {
            Console.WriteLine(item);
        }
    }
}