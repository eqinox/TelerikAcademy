using System;
class FloatingPointPrecision
{
    static void Main()
    {
        float firstNumber = float.Parse(Console.ReadLine());
        float secondNumber = float.Parse(Console.ReadLine());
        bool comparison = (firstNumber == secondNumber);
        Console.WriteLine(comparison);
    }
}
