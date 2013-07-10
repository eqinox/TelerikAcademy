/*Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set
 * [1..N]. Example:
	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
*/
using System;
class Combinations
{

    static void Combinations2(int[] arr, int start, int end, int addation)
    {
        if (start == arr.Length)
        {
            Print(arr);
        }
        else
        {
            for (int i = addation; i <= end; i++)
            {
                arr[start] = i;
                Combinations2(arr, start + 1, end, i + 1);
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
        int n = int.Parse(Console.ReadLine());
        int[] k = new int[int.Parse(Console.ReadLine())];
        Combinations2(k, 0, n, 1);
    }
}