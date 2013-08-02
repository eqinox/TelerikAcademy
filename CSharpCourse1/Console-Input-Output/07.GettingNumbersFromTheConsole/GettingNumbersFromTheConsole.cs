using System;
class GettingNumbersFromTheConsole
{
    static void Main()
    {
        Console.Write("Write How many numbers do you want to calculate: ");
        int howManyNumbers = int.Parse(Console.ReadLine());
        int number = new int();
        int sum = new int();
        for (int i = 0; i < howManyNumbers; i++)
        {
            number = int.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine("Sum of all numbers is: {0}", sum);
    }
}