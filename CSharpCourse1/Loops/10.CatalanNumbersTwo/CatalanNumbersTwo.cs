using System;
using System.Numerics;
class CatalanNumbersTwo
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger nFactorial2 = 1;
        BigInteger nFactorial3 = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            nFactorial *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            nFactorial2 *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            nFactorial3 *= i;
        }
        Console.WriteLine(nFactorial / (nFactorial2 * nFactorial3));
    }
}