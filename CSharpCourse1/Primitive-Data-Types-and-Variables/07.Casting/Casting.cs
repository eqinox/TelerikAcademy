using System;
class Casting
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object firstPlusSecond = firstString + " " + secondString;
        string thirdString = (string)firstPlusSecond;
        Console.WriteLine(thirdString);
    }
}
