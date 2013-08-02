using System;
/*Write a program that finds the greatest of given 5 variables.
*/
class GreatestNumberOfFiveNumbers
{
    static void Main()
    {
        int firstNumber = new int();
        int biggestNumber = new int();
        for (int i = 0; i < 5; i++)
        {
            firstNumber = int.Parse(Console.ReadLine());
            if (firstNumber > biggestNumber)
            {
                biggestNumber = firstNumber;
            }
        }
        Console.WriteLine(biggestNumber);
    }
}