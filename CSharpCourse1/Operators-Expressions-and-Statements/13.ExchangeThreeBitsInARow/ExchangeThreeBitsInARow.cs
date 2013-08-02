using System;
class ExchangeThreeBitsInARow
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int bitPosition3 = new int ();
        int bitPosition4 = new int ();
        int bitPosition5 = new int ();
        int bitPosition24 = new int ();
        int bitPosition25 = new int ();
        int bitPosition26 = new int ();
        int firstNumberWithoutThreeBits = new int();
        int lastNumber = new int();
        int mask = 1;
        bitPosition3 = ((mask << 3) & number) >> 3;
        bitPosition4 = ((mask << 4) & number) >> 4;
        bitPosition5 = ((mask << 5) & number) >> 5;

        // we move bit 3 4 and 5 to position 24 25 and 26
        bitPosition24 = bitPosition3 << 24;
        bitPosition25 = bitPosition4 << 25;
        bitPosition26 = bitPosition5 << 26;
        // we move bit 3 4 and 5 to position 24 25 and 26

        // here we remove the first three bits in a row and make them 0
        firstNumberWithoutThreeBits = ~(mask << 3) & number;
        firstNumberWithoutThreeBits = ~(mask << 4) & firstNumberWithoutThreeBits;
        firstNumberWithoutThreeBits = ~(mask << 5) & firstNumberWithoutThreeBits;
        // here we remove the first three bits in a row and make them 0

        // and here we assemble the last number with all parts
        lastNumber = bitPosition24 | bitPosition25 | bitPosition26 | firstNumberWithoutThreeBits;
        // and here we assemble the last number with all parts

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(lastNumber, 2).PadLeft(32, '0'));
    }
}