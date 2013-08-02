using System;
class TrapezoidArea
{
    static void Main()
    {
        int sideA = 5;
        int sideB = 9;
        int height = 13;
        int trapezoidArea = (sideA + sideB) / 2 * height;
        Console.WriteLine(trapezoidArea);
    }
}