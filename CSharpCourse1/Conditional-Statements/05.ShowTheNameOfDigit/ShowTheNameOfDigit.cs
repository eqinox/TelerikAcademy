﻿using System;
/*Write program that asks for a digit and depending on the input shows the name 
 * of that digit (in English) using a switch statement.
*/
class ShowTheNameOfDigit
{
    static void Main()
    {
        Console.WriteLine("enter a number between 1 to 10");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 1: Console.WriteLine("one");
                break;
            case 2: Console.WriteLine("two");
                break;
            case 3: Console.WriteLine("three");
                break;
            case 4: Console.WriteLine("four");
                break;
            case 5: Console.WriteLine("five");
                break;
            case 6: Console.WriteLine("six");
                break;
            case 7: Console.WriteLine("seven");
                break;
            case 8: Console.WriteLine("eight");
                break;
            case 9: Console.WriteLine("nine");
                break;
            case 10: Console.WriteLine("ten");
                break;
            default: Console.WriteLine("plase numbers between 1 to 10");
                break;
        }
    }
}