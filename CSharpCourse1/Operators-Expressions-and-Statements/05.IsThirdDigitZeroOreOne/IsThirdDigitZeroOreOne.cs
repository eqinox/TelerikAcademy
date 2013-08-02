using System;
class IsThirdDigitZeroOreOne
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int mask = 1;
        int position = 3;
        bool result = ((mask << position) & number) >> position == 1;
        Console.WriteLine(result);
    }
}
