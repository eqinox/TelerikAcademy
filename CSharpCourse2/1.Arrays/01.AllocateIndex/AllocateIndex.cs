/*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
 * Print the obtained array on the console.
*/
using System;
class AllocateIndex
{
    static void Main()
    {
        int[] numbers = {2, 3, 4, 5, 6, 1, 123, 12, 23, 345, 567, 765, 123, 234, 12346, 2356, 123, 234, 2354, 56};
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("{0} index is {1, -10}| index * 5 = {2}", i, numbers[i], i * 5);
        }
    }
}