/*Write a program to convert hexadecimal numbers to their decimal representation.
*/
using System;
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter number as hexadecimal representation: ");
        string hexadecimalNumber = Console.ReadLine();
        ulong numberInDecimal = new ulong();
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            string element = hexadecimalNumber[hexadecimalNumber.Length - i - 1].ToString();
            switch (element)
            {
                case "A": numberInDecimal += 10 * (ulong)Math.Pow(16, i);
                    break;
                case "B": numberInDecimal += 11 * (ulong)Math.Pow(16, i);
                    break;
                case "C": numberInDecimal += 12 * (ulong)Math.Pow(16, i);
                    break;
                case "D": numberInDecimal += 13 * (ulong)Math.Pow(16, i);
                    break;
                case "E": numberInDecimal += 14 * (ulong)Math.Pow(16, i);
                    break;
                case "F": numberInDecimal += 15 * (ulong)Math.Pow(16, i);
                    break;
                default: numberInDecimal += ulong.Parse(element) * (ulong)Math.Pow(16, i);
                    break;
            }

        }
        Console.WriteLine("Decimal representation of the number is: {0}", numberInDecimal);
    }
}