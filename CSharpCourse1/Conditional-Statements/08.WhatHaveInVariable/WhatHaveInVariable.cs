using System;
/*Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or
 * double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable
 * as a console output. Use switch statement.
*/
class WhatHaveInVariable
{
    static void Main()
    {
        dynamic jsutVariable = Console.ReadLine();
        int isInt;
        double isDouble;
        if (int.TryParse(jsutVariable, out isInt))
        {
            Console.WriteLine(isInt + 1);
        }
        else if (double.TryParse(jsutVariable, out isDouble))
        {
            Console.WriteLine(isDouble + 1);
        }
        else
        {
            Console.WriteLine(jsutVariable + "*");
        }
    }
}