/*Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.
*/
using System;
class NumInArray
{
    static void CounterOFNumber(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int currentCounter = 1;
            for (int j = i; j < arr.Length - 1; j++)
            {
                if (arr[i] == arr[j + 1])
                {
                    currentCounter++;
                }
            }
            if (currentCounter > 1)
            {
                Console.WriteLine("{0} appears {1} times", arr[i], currentCounter);
            }
        }
    }
    static void Main()
    {
        int[] arr = new int [10];
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
        CounterOFNumber(arr);
        Console.WriteLine("Start the program for another test");
    }
}