/*Write a program that finds all prime numbers in the range [1...10 000 000]. 
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
*/
using System;
class SieveOfEratosthenes
{
    static void Main()
    {
        int counter = 0;
        bool[] numbers = new bool[10000000];
        for (int i = 2; i < Math.Sqrt(numbers.Length); i++)
        {
            if (numbers[i] == false)
            {
                for (int j = i * i; j < numbers.Length; j+=i)
                {
                    numbers[j] = true;
                }
            }
        }
        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i] == false)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}