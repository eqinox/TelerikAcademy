/*Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
*/
using System;
class ConvertToAnyNumeralSystem
{
    static void Main()
    {
        Console.Write("Choose numeral system: ");
        int numeralSystemFrom = int.Parse(Console.ReadLine());
        Console.Write("Enter the number: ");
        string theNumber = Console.ReadLine();
        Console.Write("Choose numeral system to convert: ");
        int numeralSystemTo = int.Parse(Console.ReadLine());
        string wantedNumber = "";
        int numberInDecimal = new int();
        //To Decimal
        if (numeralSystemFrom != 10)
        {
            for (int i = 0; i < theNumber.Length; i++)
            {
                char element = theNumber[theNumber.Length - i - 1];
                if (element - 55 > 9)
                {
                    numberInDecimal += (element - 55) * (int)Math.Pow(numeralSystemFrom, i);
                }
                else
                {
                    numberInDecimal += (element - 48) * (int)Math.Pow(numeralSystemFrom, i);
                }
            }
        }
        else
        {
            numberInDecimal = int.Parse(theNumber);
        }
        //To wanted numeral system
        if (numeralSystemTo != 10)
        {
            while (numberInDecimal != 0)
            {
                char element = (char)(numberInDecimal % numeralSystemTo);
                if (element > 9)
                {
                    wantedNumber += (char)(element + 55);
                }
                else
                {
                    wantedNumber += ((int)element).ToString();
                }
                numberInDecimal /= numeralSystemTo;
            }
            for (int i = wantedNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(wantedNumber[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(numberInDecimal);
        }
    }
}