using System;
using System.Globalization;
using System.Threading;
class ReverseDigits
{
    static double ReverseDigits2(double num)
    {
        string numAsStr = num.ToString();
        string newstr = "";
        for (int i = 1; i <= numAsStr.Length; i++)
        {
            if (numAsStr[numAsStr.Length - i] == '.')
            {
                continue;
            }
            newstr += numAsStr[numAsStr.Length - i];
        }
        return double.Parse(newstr);
    }
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Write a number: ");
        double number = double.Parse(Console.ReadLine());
        number = ReverseDigits2(number);
        Console.WriteLine("Reversed number is: ");
        Console.WriteLine(number);
    }
}
