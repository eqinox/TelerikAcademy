/*Write a program to convert binary numbers to hexadecimal numbers (directly).
*/
using System;
class BinaryToHexadecimal
{
    static string ReverseDigits(string digits)
    {
        string tempDigits = digits;
        digits = "";
        for (int i = tempDigits.Length - 1; i >= 0; i--)
        {
            digits += tempDigits[i];
        }
        return digits;
    }
    static void Main()
    {
        Console.Write("Enter number in binary: ");
        string numAsBinary = Console.ReadLine();
        string numAsHexadecimal = "";
        string helpToConvert = "";

        for (int i = numAsBinary.Length - 1, j = 1; i >= 0; i--, j++)
        {
            helpToConvert += numAsBinary[i];
            if (i == 0 && j != 4)
            {
                j = 4;
            }
            if (j == 4)
            {
                while (helpToConvert.Length != 4)
                {
                    helpToConvert += "0";
                }
                switch (ReverseDigits(helpToConvert))
                {
                    case "0000": numAsHexadecimal += "0";
                        break;
                    case "0001": numAsHexadecimal += "1";
                        break;
                    case "0010": numAsHexadecimal += "2";
                        break;
                    case "0011": numAsHexadecimal += "3";
                        break;
                    case "0100": numAsHexadecimal += "4";
                        break;
                    case "0101": numAsHexadecimal += "5";
                        break;
                    case "0110": numAsHexadecimal += "6";
                        break;
                    case "0111": numAsHexadecimal += "7";
                        break;
                    case "1000": numAsHexadecimal += "8";
                        break;
                    case "1001": numAsHexadecimal += "9";
                        break;
                    case "1010": numAsHexadecimal += "A";
                        break;
                    case "1011": numAsHexadecimal += "B";
                        break;
                    case "1100": numAsHexadecimal += "C";
                        break;
                    case "1101": numAsHexadecimal += "D";
                        break;
                    case "1110": numAsHexadecimal += "E";
                        break;
                    case "1111": numAsHexadecimal += "F";
                        break;
                    default:
                        break;
                }
                helpToConvert = "";
                j = 0;
            }
        }
        Console.Write("Num as hexadecimal is: ");
        for (int i = numAsHexadecimal.Length - 1; i >= 0; i--)
        {
            Console.Write(numAsHexadecimal[i]);
        }
        Console.WriteLine();
    }
}