using System;
class ExchangeValueOfBinaryRepresentation
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(15, '0'));
        Console.Write("which bit do you want to exchange: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("exchange it with zero or one? : ");
        int value = int.Parse(Console.ReadLine());
        int mask = 1;
        int bit = ((mask << position) & number) >> position;
        if (bit == value)
        {
            int exchangeBitWithOne = (mask << position) | number;
            Console.WriteLine(Convert.ToString(exchangeBitWithOne, 2).PadLeft(15, '0'));
        }
        else
        {
            int exchangeBitWithZero = (mask << position) ^ number;
            Console.WriteLine(Convert.ToString(exchangeBitWithZero, 2).PadLeft(15, '0'));
        }
    }
}