/*Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using
 * the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
*/
using System;
class BinarySearch
{
    static void Main()
    {
        Console.Write("Length= ");
        int[] numbers = new int[int.Parse(Console.ReadLine())];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}= ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(numbers);

        if (numbers[0] > k)
        {
            Console.WriteLine("there havent that element");
            return;
        }
        int position = Array.BinarySearch(numbers, k);

        if (position >= 0)
        {
            Console.WriteLine(numbers[position]);
        }
        else
        {
            Console.WriteLine(numbers[~position - 1]);
        }
    }
}