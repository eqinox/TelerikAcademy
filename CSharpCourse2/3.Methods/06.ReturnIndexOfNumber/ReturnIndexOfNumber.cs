/*Write a method that returns the index of the first element in array that is bigger than its neighbors,
 * or -1, if there’s no such element.
Use the method from the previous exercise.
*/
using System;
class ReturnIndexOfNumber
{
    static void CheckNumber(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                Console.WriteLine("Index = {0}({1})", i, arr[i]);
                return;
            }
        }
        Console.WriteLine("-1");
    }
    static void Main()
    {
        int[] arr = new int[5];
        Random setElements = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = setElements.Next(1, 5);
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