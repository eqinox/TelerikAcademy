﻿using System;
class CalculateZeroes
{
    static void Main()
    {
        Console.Write("Enter number for N: ");
        int userInput = int.Parse(Console.ReadLine());
        int counterZeroes = 0;
        int square = 1;
        int divisor = 5;
        int rezult = 0;
        while (true)
        {
            square *= divisor;
            rezult = userInput / square;
            counterZeroes += rezult;
            if (rezult == 0)
            {
                break;
            }
        }
        Console.WriteLine("There are {0} trailing zeros.", counterZeroes);
    }
}