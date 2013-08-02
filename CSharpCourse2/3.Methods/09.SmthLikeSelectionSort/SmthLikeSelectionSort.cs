/*Write a method that return the maximal element in a portion of array of integers starting at given index. 
 * Using it write another method that sorts an array in ascending / descending order.
*/
using System;
using System.Collections.Generic;
class SmthLikeSelectionSort
{

    static int[] GetBiggestNum(List<int> arr, int whenToFinish, int[] numbers)
    {
        if (whenToFinish == 0)
        {
            return numbers;
        }
        int[] biggestNum = { arr[0] };
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > biggestNum[0])
            {
                biggestNum[0] = arr[i];
            }
        }
        arr.Remove(biggestNum[0]);
        return FillNewArr(arr, biggestNum, numbers, whenToFinish - 1);
    }
    static int[] FillNewArr(List<int> list ,int[] number, int[] numbers, int position)
    {
        numbers[position] = number[0];
        return GetBiggestNum(list, position, numbers); 
    }

    static void PrintArr(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0 ; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int length = 10;
        List<int> numbers = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < length; i++)
        {
            numbers.Add(rand.Next(1, 21));
        }
        int whenToFinish = numbers.Count;
        int[] newNumbers = new int[numbers.Count];
        PrintArr(GetBiggestNum(numbers, whenToFinish, newNumbers));
        Console.WriteLine("Start the program for another test");

    }
}