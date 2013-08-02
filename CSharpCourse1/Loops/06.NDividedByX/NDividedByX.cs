using System;
class NDividedByX
{
    static void Main()
    {
        Console.Write("Write X: ");
        int numberForX = int.Parse(Console.ReadLine());
        Console.Write("Write N: ");
        int numberForN = int.Parse(Console.ReadLine());
        long nFactorial = 1;
        decimal sum = 0m;
        for (int i = 1; i <= numberForN; i++)
        {
            nFactorial = nFactorial * i;
        }
        for (int i = 1; i <= numberForN; i++)
        {
            sum = sum + (i * i) / (decimal)Math.Pow(numberForX, i);
        }

        Console.WriteLine(sum);
    }
}