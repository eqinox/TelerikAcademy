using System;
class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string evenOrOdd = (number & 1) == 0 ? "Even" : "Odd";
        Console.WriteLine(evenOrOdd);
        //if ((number & 1) == 0)
        //{
        //    Console.WriteLine("Number is even");
        //}
        //else
        //{
        //    Console.WriteLine("Number is odd");
        //}
    }
}
