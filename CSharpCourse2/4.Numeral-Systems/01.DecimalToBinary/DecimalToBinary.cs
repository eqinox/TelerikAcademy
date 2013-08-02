using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int numAsDecimal = int.Parse(Console.ReadLine());
        string digits = "";

        while (numAsDecimal != 0)
        {
            digits += numAsDecimal % 2;
            numAsDecimal /= 2;
        }
        Console.Write("Binari representation of number is: ");
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}