using System;
class BitAtPositionExtractValue
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = 1;
        int bit = ((mask << position) & number) >> position;
        Console.WriteLine(bit);
    }
}