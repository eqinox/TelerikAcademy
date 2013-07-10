/*Write a program that reads two arrays from the console and compares them element by element.
*/
using System;
class CompareElements
{
    static void Main()
    {
        int[] firstArray = new int[10];
        int[] secondArray = new int[10];
        Random randomGenerator = new Random();
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = randomGenerator.Next(1, 50);
        }

        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = randomGenerator.Next(1, 50);
        }

        for (int i = 0; i < 10; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("first array index {0} = {1, 5} > {2, -6} = second array index {0}", i, firstArray[i], secondArray[i]);
            }
            else
            {
                Console.WriteLine("first array index {0} = {1, 5} < {2, -6} = second array index {0}", i, firstArray[i], secondArray[i]);
            }
        }
    }
}