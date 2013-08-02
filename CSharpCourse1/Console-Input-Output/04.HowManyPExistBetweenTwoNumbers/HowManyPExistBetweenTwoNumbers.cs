using System;
class HowManyPExistBetweenTwoNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int count = new int();
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}