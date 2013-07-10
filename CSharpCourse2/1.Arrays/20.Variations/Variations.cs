/*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
*/
using System;
class Variations
{

    static private  void Variations2 (int[] arr, int start, int end)
    {
        if (start == arr.Length)
        {
            Print(arr);
        }
        else
        {
            for (int i = 1; i <= end; i++)
            {
                arr[start] = i;
                Variations2(arr, start + 1, end);
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
        Variations2(k, 0, n);
    }
}