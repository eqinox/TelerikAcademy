using System;
class MinMaxAndAverage
{
    static int GetMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (min < arr[i])
            {
                min = arr[i];
            }
        }
        return min;
    }
    static int GetMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (max > arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }

    static int AverageNumbers(int[] nums)
    {
        int sum = 0;
        foreach (var item in nums)
        {
            sum += item;
        }
        int average = sum / nums.Length;
        int position = Array.BinarySearch(nums, average);
        if (position >= 0)
        {
            average = nums[position];
        }
        else
        {
            average = nums[~position];
        }
        return average;
    }
    static int GatherArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static ulong MultiplyArr(int[] arr)
    {
        int sum = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            sum *= arr[i];
        }
        return (ulong)sum;
    }

    static void Main()
    {
        int[] numbers = new int[15];
        Random rand = new Random();
        Console.WriteLine("Numbers are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 500);
            Console.Write(numbers[i] + ", ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Min = {0}", GetMin(numbers));
        Console.WriteLine("Max = {0}", GetMax(numbers));
        Console.WriteLine("Average = {0}", AverageNumbers(numbers));
        Console.WriteLine("Sum with \"+\" = {0}", GatherArray(numbers));
        Console.WriteLine("Multiply = {0}", MultiplyArr(numbers));

    }
}