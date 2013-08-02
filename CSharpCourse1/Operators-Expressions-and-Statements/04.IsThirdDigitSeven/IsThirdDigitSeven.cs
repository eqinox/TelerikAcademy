using System;
class IsThirdDigitSeven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result = (number / 100) % 10 == 7;
        Console.WriteLine(result);
    }
}