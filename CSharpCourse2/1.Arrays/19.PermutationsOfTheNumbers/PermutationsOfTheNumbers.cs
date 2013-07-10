/** Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
*/
using System;
class PermutationsOfTheNumbers
{
    static void Permute(int[] numbers, bool[] used, int position)
    {
        if (position == numbers.Length)
        {
            Print(numbers);
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }
                numbers[position] = i + 1;
                used[i] = true;
                Permute(numbers, used, position + 1);
                used[i] = false;
            }
        }
    }

    static void Print(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("n= ");
        int[] numbers = new int[int.Parse(Console.ReadLine())];

        bool[] used = new bool[numbers.Length];

        Permute(numbers, used, 0);
    }
}