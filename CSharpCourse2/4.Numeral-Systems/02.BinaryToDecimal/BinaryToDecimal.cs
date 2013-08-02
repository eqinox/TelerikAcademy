using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter number as binary representation: ");
        string binaryNumber = Console.ReadLine();
        int numberInDecimal = new int();
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int elementPosition = int.Parse(binaryNumber[binaryNumber.Length - i - 1].ToString());
            int number = (int)Math.Pow(elementPosition * 2, i);
            numberInDecimal += number;
        }
        Console.WriteLine("Decimal representation of the number is: {0}", numberInDecimal);
    }
}