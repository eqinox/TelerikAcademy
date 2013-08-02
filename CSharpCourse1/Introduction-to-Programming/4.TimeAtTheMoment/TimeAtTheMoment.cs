using System;

class TimeAtTheMoment
{
    static void Main()
    {
        DateTime Format = DateTime.Now;
        string time = Format.ToString();
        Console.WriteLine(time);
    }
}
