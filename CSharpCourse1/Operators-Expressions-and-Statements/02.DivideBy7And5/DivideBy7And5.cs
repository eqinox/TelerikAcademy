using System;
class DivideBySevenAndFive
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result = (number % 7 == 0) && (number % 5 == 0);
        string result2 = (number % 7 == 0) && (number % 5 == 0) ? "divide by 3 and 5 at the same time" : "type another number";
        Console.WriteLine(result);
        Console.WriteLine(result2);
    }
}