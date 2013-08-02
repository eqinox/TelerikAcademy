using System;
class BitAtPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = 1;
        bool bitAtPosition = ((mask << position) & number) >> position == 1;
        Console.WriteLine(bitAtPosition);
    }
}