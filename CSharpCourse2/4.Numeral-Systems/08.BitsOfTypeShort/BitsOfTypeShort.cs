using System;
class BitsOfTypeShort
{
    static string Reverse(string str)
    {
        string newStr = str;
        str = "";

        for (int i = newStr.Length - 1; i >= 0; i--)
        {
            str += newStr[i];
        }
        return str;

    }
    static string ExchangeZeroWithOne(string str)
    {
        char[] arr = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            char currentChar = str[i] == '1' ? currentChar = '0' : currentChar = '1';
            arr[i] = currentChar;
        }
        str = "";
        for (int i = 0; i < arr.Length; i++)
        {
            str += arr[i];
        }
        return str;
    }
    static void Main()
    {
        Console.Write("Enter number between 32767 and -32768: ");
        int theNumber = int.Parse(Console.ReadLine());
        string digits = "";
        
        if (theNumber > 32767 || theNumber < -32768)
        {
            Console.WriteLine("enter in valid range");
        }
        else if (theNumber >= 0)
        {
            while (theNumber != 0)
            {
                digits += theNumber % 2;
                theNumber /= 2;
            }
            digits = Reverse(digits);
            while (digits.Length % 16 != 0)
            {
                digits = "0" + digits;
            }
            Console.WriteLine(digits);
        }
        else if (theNumber < 0)
        {
            theNumber = (short)(Math.Abs(theNumber) - 1);
            while (theNumber != 0)
            {
                digits += theNumber % 2;
                theNumber /= 2;
            }
            digits = Reverse(digits);
            while (digits.Length % 16 != 0)
            {
                digits = "0" + digits;
            }

            digits = ExchangeZeroWithOne(digits);
            Console.WriteLine(digits);
        }
    }
}