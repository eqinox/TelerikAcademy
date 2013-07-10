/*Write a program that finds the index of given element in a sorted array of integers
 * by using the binary search algorithm (find it in Wikipedia).
*/
using System;
class BinarySearchAlgorithm
{
    static void Main()
    {
        int[] arr = new int[100];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 101);
        }
        System.Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0, -3}", arr[i]);
        }
        Console.WriteLine("\n");
        int max = arr.Length - 1;
        int min = 0;
        Console.Write("Enter one number and the program will tell you in which position is it: ");
        int wantedNumber = int.Parse(Console.ReadLine());
        while (max >= min)
        {
            int middle = (max + min) / 2;
            if (arr[middle] < wantedNumber)
            {
                min = middle + 1;
            }
            else if (arr[middle] > wantedNumber)
            {
                max = middle - 1;
            }
            else
            {
                Console.WriteLine("your number {0} is at {1} position", wantedNumber, middle);
                break;
            }
        }
    }
}