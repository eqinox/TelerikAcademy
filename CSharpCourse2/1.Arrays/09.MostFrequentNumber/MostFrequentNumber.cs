/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/
using System;
class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int counter = 0;
        int theElement = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int currentCounter = 0;
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    currentCounter++;
                }
            }
            if (currentCounter > counter)
            {
                counter = currentCounter;
                theElement = array[i];
            }
        }
        Console.WriteLine("({0}) is repeated ({1}) times", theElement, counter);
    }
}