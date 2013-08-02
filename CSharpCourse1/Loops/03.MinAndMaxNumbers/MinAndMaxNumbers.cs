using System;
class MinAndMaxNumbers
{
    static void Main()
    {
        Console.WriteLine("How many numbers do you want to type: ");
        int numbers = int.Parse(Console.ReadLine());
        int biggestNum = new int();
        int smallestNum = new int();
        for (int i = 0; i < numbers; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                smallestNum = number;
            }

            if (number > biggestNum)
            {
                biggestNum = number;
            }

            if (smallestNum > number)
            {
                smallestNum = number;
            }
        }
        Console.WriteLine("Biggest number is: {0}", biggestNum);
        Console.WriteLine("Smallest number is: {0}", smallestNum);
    }
}