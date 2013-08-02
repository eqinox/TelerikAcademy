/*Write a program to convert decimal numbers to their hexadecimal representation.
*/
using System;
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int numDecimal = int.Parse(Console.ReadLine());
        string numAsHexadecimal = "";
        while (numDecimal != 0)
        {
            int element = numDecimal % 16;
            switch (element)
            {
                case 15: numAsHexadecimal += "F";
                    break;
                case 14: numAsHexadecimal += "E";
                    break;
                case 13: numAsHexadecimal += "D";
                    break;
                case 12: numAsHexadecimal += "C";
                    break;
                case 11: numAsHexadecimal += "B";
                    break;
                case 10: numAsHexadecimal += "A";
                    break;
                default: numAsHexadecimal += element.ToString();
                    break;
            }
            numDecimal /= 16;
        }
        Console.WriteLine("number is hexadecimal: ");
        for (int i = numAsHexadecimal.Length - 1; i >= 0; i--)
        {
            Console.Write(numAsHexadecimal[i]);
        }
        Console.WriteLine();
    }
}