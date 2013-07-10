/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.
*/
using System;
class SortingArray
{
    static void Main()
    {
        Console.Write("Write how many elements do you want to put in your array: ");
        int numberOfElements = int.Parse(Console.ReadLine());
        int[] unOrderedArray = new int[numberOfElements];
        for (int i = 0; i < unOrderedArray.Length; i++)
        {
            Console.Write("{0} element is: ", i);
            unOrderedArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numberOfElements - 1; i++)
        {
            int smallestNum = i;
            for (int j = i + 1; j < numberOfElements; j++)
            {
                if (unOrderedArray[smallestNum] > unOrderedArray[j])
                {
                    smallestNum = j;
                }
            }
            if (smallestNum != i)
            {
                int current = unOrderedArray[i];
                unOrderedArray[i] = unOrderedArray[smallestNum];
                unOrderedArray[smallestNum] = current;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Sorted array is: ");
        for (int i = 0; i < numberOfElements; i++)
        {
            Console.WriteLine("{0} element is: {1}", i, unOrderedArray[i]);
        }
    }
}
