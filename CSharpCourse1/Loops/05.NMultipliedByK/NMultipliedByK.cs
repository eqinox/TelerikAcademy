using System;
class NMultipliedByK
{
    static void Main()
    {
        Console.Write("Write K: ");
        int numberForK = int.Parse(Console.ReadLine());
        Console.Write("Write N: ");
        int numberForN = int.Parse(Console.ReadLine());
        long nFactorial = 1;
        long kFactorial = 1;
        for (int i = 1; i <= numberForN; i++)
        {
            nFactorial = nFactorial * i;
        }
        for (int i = 1; i <= numberForK; i++)
        {
            kFactorial *= i;
        }
        Console.WriteLine("N! * K! / K - N = {0}", (nFactorial * kFactorial) / (numberForK - numberForN));
    }
}
