using System;
class ExchangeValueOfTheBitsAgain
{
    static void Main()
    {
        Console.Write("The number that you want to use: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.Write("From which bit do you want to start to exchange: ");
        int positionToExchange = int.Parse(Console.ReadLine());
        Console.Write("How many bits in a row do you want to exchange after first bit that you noted: ");
        int howManyBitsToExchange = int.Parse(Console.ReadLine());
        Console.Write("in which position do you want to put theese bits: ");
        int whereToMoveBits = int.Parse(Console.ReadLine()); 
        int mask = 1;
        int firstBit = ((mask << positionToExchange) & number) >> positionToExchange; // the first bit of the number that we noted. we will move it
        int[] otherBits = new int[howManyBitsToExchange + 1];                         // with << whereToMoveBits at the end
        int firstNumberWithoutBits = new int();
        int finalNumber = new int();
        for (int i = 1; i <= howManyBitsToExchange; i++)
        {
            otherBits[i] = ((mask << positionToExchange + i) & number) >> positionToExchange + i; // all other bits we will move them with 
        }                                                                                         // << whereToMoveBits at the end

        finalNumber = firstBit << whereToMoveBits;

        for (int i = 1; i <= howManyBitsToExchange; i++)
        {
            finalNumber = finalNumber | (otherBits[i] << (whereToMoveBits + i));
        }

        firstNumberWithoutBits = ~(mask << positionToExchange) & number; // here we remove first bit of the sequence. we make him 0

        for (int i = 1; i <= howManyBitsToExchange; i++)
        {
            firstNumberWithoutBits = ~(mask << positionToExchange + i) & firstNumberWithoutBits; // all other bits. make them 0;
        }

        finalNumber = finalNumber | firstNumberWithoutBits;
        Console.WriteLine(Convert.ToString(finalNumber, 2).PadLeft(32, '0'));
    }
}