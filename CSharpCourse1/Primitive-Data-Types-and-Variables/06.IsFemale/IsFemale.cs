using System;
class IsFemale
{
    static void Main()
    {
        Console.Write("Enter your full first name in latin:");
        string yourName = Console.ReadLine();
        bool isFemale = ( (yourName.Substring(yourName.Length - 1) == "a") || (yourName.Substring(yourName.Length - 1) == "i")
            || (yourName.Substring(yourName.Length - 1) == "q"));
        if (isFemale)
        {
            Console.WriteLine("You are female");
        }
        else
        {
            Console.WriteLine("You are male");
        }
    }
}
