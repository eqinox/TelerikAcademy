using System;
class PrimeNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int maxDivisor = (int)Math.Sqrt(number);
        for (int i = 2; i <= maxDivisor; i++)
        {
            if (number % i == 0)
            {
                break;
            }
            if (i == maxDivisor)
            {
                Console.WriteLine(true);
            }
        }
    }
}