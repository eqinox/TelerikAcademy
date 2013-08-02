/*Write a method that checks if the element at given position in given array of integers
 * is bigger than its two neighbors (when such exist).
*/
using System;
class NumberBetweenTwoNumbers
{
    static void CheckNumber(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                Console.WriteLine("{2}<{0}>{1}", arr[i], arr[i+1], arr[i-1]);
            }
        }
    }
    static void Main()
    {
        int[] arr = new int[10];
        Random setElements = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = setElements.Next(1, 10);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        CheckNumber(arr);
        Console.WriteLine("Start the program for another test");
    }
}