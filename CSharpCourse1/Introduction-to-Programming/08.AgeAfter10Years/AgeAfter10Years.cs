using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Month that you are born:");
        int mineMonth = int.Parse(Console.ReadLine());
        Console.WriteLine("Date that you are born:");
        int mineDate = int.Parse(Console.ReadLine());
        Console.WriteLine("Year that you are born:");
        int mineYears = int.Parse(Console.ReadLine());
        string year = "yyyy";
        string month = "MM";
        string date = "dd";
        DateTime time = DateTime.Now;
        if (int.Parse(time.ToString(month)) < mineMonth)
        {
            Console.WriteLine(int.Parse(time.ToString(year)) - mineYears - 1);
        }
        else if (int.Parse(time.ToString(month)) == mineMonth)
        {
            if (int.Parse(time.ToString(date)) < mineDate)
            {
                Console.WriteLine(int.Parse(time.ToString(year)) - mineYears - 1);
            }
            else
            {
                Console.WriteLine(int.Parse(time.ToString(year)) - mineYears);
            }
        }
        else
        {
            if (int.Parse(time.ToString(date)) < mineDate)
            {
                Console.WriteLine(int.Parse(time.ToString(year)) - mineYears - 1);
            }
            else
            {
                Console.WriteLine(int.Parse(time.ToString(year)) - mineYears);
            }
        }
        //Console.WriteLine(int.Parse(time.ToString(year)) - mineYears + 10);
    }
}
