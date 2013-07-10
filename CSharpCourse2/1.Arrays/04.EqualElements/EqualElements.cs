/*Write a program that finds the maximal sequence of equal elements in an array.
*/
using System;
using System.Collections.Generic;
class EqualElements
{
    static void Main()
    {
        Console.WriteLine("Write 10 numbers");
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int length = 1;
        int bestLength = 0;
        int bestStart = 0;
        List<int> sequence = new List<int>();
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i+1])
            {
                length++;

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = i - length + 2;
                }
            }
            else
            {
                length = 1;
            }
        }
        for (int i = bestStart; i < bestStart + bestLength; i++)
        {
            sequence.Add(numbers[i]);
        }
        Console.WriteLine();
        foreach (var item in sequence)
        {
            Console.WriteLine(item);
        }
    }
}